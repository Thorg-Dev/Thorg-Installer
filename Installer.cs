using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Thorg_Installer.Config;

namespace Thorg_Installer
{
    class InstallerEvent
    {
        public string Message { get; set; }

        public int Step { get; set; } = -1;

        public int Total { get; set; } = -1;

        public bool IsDone { get; set; }

        public bool IsError { get; set; }

    }

    /// <summary>
    /// General instalation logic
    /// </summary>
    class Installer
    {

        public Uri BaseUri { get; private set; }
        public App Descriptor { get; set; }

        public string InstallDir { get; set; }

        private Component[] _downloads = null;

        private string CachePath => Path.Combine(InstallDir, @"cache");

        public string VersionPath => Path.Combine(InstallDir, $"v{Descriptor.Version}");

        public string ThorgExePath => Path.Combine(VersionPath, @"ThorgMiner.exe");

        private string DescriptorPath => Path.Combine(InstallDir, @"thorg.xml");

        public Installer(Uri baseUri)
        {
            BaseUri = baseUri;
            InstallDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Thorg");
        }

        public bool Prepare()
        {
            var currentDescriptorPath = DescriptorPath;

            if (File.Exists(currentDescriptorPath))
            {
                var currentDescriptor = App.FromFile(currentDescriptorPath);
                var diff = Descriptor.DiffrenceTo(currentDescriptor);
                if (diff.Count == 0)
                {
                    _downloads = new Component[0];
                    return false;
                }
                _downloads = diff.ToArray();
            }
            else
            {
                _downloads = Descriptor.GetAllComponents().ToArray();
            }
            return true;
        }

        public void Run(Action<InstallerEvent> progress)
        {
            Task.Run(() =>
            {
                var allComponents = Descriptor.GetAllComponents();
                int step = 0;
                int total = _downloads.Length + allComponents.Count + 1;
                progress?.Invoke(new InstallerEvent()
                {
                    Message = "Creating Directories",
                    Step = step,
                    Total = total
                });


                CreatePaths();
                var cache = CachePath;
                foreach (var c in _downloads)
                {
                    ++step;
                    using (var client = new WebClient())
                    {
                        var downloadedFile = Path.Combine(cache, $"{c.Download}.zip");
                        if (File.Exists(downloadedFile))
                        {
                            progress?.Invoke(new InstallerEvent()
                            {
                                Message = $"Checking {c.Download}",
                                Step = step,
                                Total = total
                            });
                            if (HashFileSHA256(downloadedFile) == c.Sha256)
                            {
                                continue;
                            }
                            else
                            {
                                File.Delete(downloadedFile);
                            }
                        }
                        progress?.Invoke(new InstallerEvent()
                        {
                            Message = $"Downloading {c.Download}",
                            Step = step,
                            Total = total
                        });
                        client.DownloadFile(new Uri(BaseUri, c.Download), downloadedFile);
                        progress?.Invoke(new InstallerEvent()
                        {
                            Message = $"Checking {c.Download}",
                            Step = step,
                            Total = total
                        });
                        var fileChecksum = HashFileSHA256(downloadedFile);
                        if (!fileChecksum.Equals(c.Sha256, StringComparison.OrdinalIgnoreCase))
                        {
                            progress?.Invoke(new InstallerEvent()
                            {
                                Message = $"Invalid checksum for {c.Download}",
                                IsError = true
                            });
                            return;
                        }
                    }
                }
                var outputDir = VersionPath;
                foreach (var c in Descriptor.GetAllComponents())
                {
                    progress?.Invoke(new InstallerEvent()
                    {
                        Message = $"Extracting {c.Download}",
                        Step = ++step,
                        Total = total
                    });
                    ZipFile.ExtractToDirectory(Path.Combine(cache, $"{c.Download}.zip"), outputDir);
                }
                SelfInstall();

                IShellLink link = (IShellLink)new ShellLink();
                link.SetDescription("Thorg Miner");
                link.SetPath(ThorgExePath);
                // save it
                string commonStartMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
                string appStartMenuPath = Path.Combine(commonStartMenuPath, "Programs");
                if (!Directory.Exists(appStartMenuPath))
                {
                    Directory.CreateDirectory(appStartMenuPath);
                }
                IPersistFile file = (IPersistFile)link;
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                file.Save(Path.Combine(appStartMenuPath, "Thorg Miner.lnk"), false);
                file.Save(Path.Combine(InstallDir, "Thorg.lnk"), false);
                progress?.Invoke(new InstallerEvent()
                {
                    Message = $"Done",
                    Step = total,
                    Total = total,
                    IsDone = true
                });
                Descriptor.ToFile(DescriptorPath);
            }).ContinueWith((t) =>
            {
                using (var entry = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GolemFactory\ThorgMiner"))
                {
                    entry.SetValue("installationDirectory", InstallDir);
                }

                if (t.IsFaulted)
                {
                    var sb = new StringBuilder();
                    sb.AppendLine(t.Exception.Message);
                    foreach (var innerEx in t.Exception.InnerExceptions)
                    {
                        sb.AppendLine(innerEx.Message);
                    }
                    progress?.Invoke(new InstallerEvent()
                    {
                        Message = sb.ToString(),
                        IsDone = true,
                        IsError = true
                    });
                }
            });
        }

        public bool UninstallThorg(bool shouldRemoveConfigFiles, bool shouldRemoveYagna)
        {
            String ThorgsPath = GetThorgsInstalledInstanceDirectory();
            if (System.IO.Directory.Exists(ThorgsPath))
            {
                System.IO.Directory.Delete(ThorgsPath, true);
                using (var entry = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GolemFactory\ThorgMiner"))
                {
                    entry.DeleteValue("installationDirectory");
                }
            }
            else
            {
                throw new DirectoryNotFoundException("Thorg's installation folder not found");
            }

            var configDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GolemFactory");
            var yagnaDir1 = Path.Combine(configDir, "yagna");
            var yagnaDir2 = Path.Combine(configDir, "ya-provider");
            var thorgConfig = Path.Combine(configDir, "ThorgMiner");

            if (shouldRemoveConfigFiles && shouldRemoveYagna && System.IO.Directory.Exists(configDir))
            {
                System.IO.Directory.Delete(configDir, true);

            }
            else if (shouldRemoveYagna)
            {
                if (System.IO.Directory.Exists(yagnaDir1))
                {
                    System.IO.Directory.Delete(yagnaDir1, true);
                }
                if (System.IO.Directory.Exists(yagnaDir2))
                {
                    System.IO.Directory.Delete(yagnaDir2, true);
                }
            }
            else if (shouldRemoveConfigFiles && System.IO.Directory.Exists(thorgConfig))
            {
                if (System.IO.Directory.Exists(thorgConfig))
                {
                    System.IO.Directory.Delete(thorgConfig, true);
                }
            }

            return true;
        }
        private string GetThorgsInstalledInstanceDirectory()
        {
            using (var entry = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\GolemFactory\ThorgMiner"))
            {
                if (entry?.GetValue("installationDirectory") is string S)
                {
                    return S;
                }
            }
            return null;
        }

        /// <summary>
        /// Installs it self.
        /// </summary>
        private void SelfInstall()
        {
            var srcPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            var destination = Path.Combine(InstallDir, "Thorg Installer.exe");
            if (srcPath != destination)
            {
                File.Copy(srcPath, destination, true);
            }
        }

        private static void CreateDirIfNotExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private static void RecreateDir(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            else
            {
                Directory.Delete(path, true);
                Directory.CreateDirectory(path);
            }
        }

        private void CreatePaths()
        {
            CreateDirIfNotExists(CachePath);
            RecreateDir(VersionPath);
        }

        private string HashFileSHA256(string path)
        {
            using (var mySHA256 = SHA256.Create())
            using (var f = File.OpenRead(path))
            {
                byte[] hashValue = mySHA256.ComputeHash(f);
                var sb = new StringBuilder();
                foreach (var b in hashValue)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }


        [ComImport]
        [Guid("00021401-0000-0000-C000-000000000046")]
        internal class ShellLink
        {
        }

        [ComImport]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [Guid("000214F9-0000-0000-C000-000000000046")]
        internal interface IShellLink
        {
            void GetPath([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cchMaxPath, out IntPtr pfd, int fFlags);
            void GetIDList(out IntPtr ppidl);
            void SetIDList(IntPtr pidl);
            void GetDescription([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszName, int cchMaxName);
            void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);
            void GetWorkingDirectory([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir, int cchMaxPath);
            void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);
            void GetArguments([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cchMaxPath);
            void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);
            void GetHotkey(out short pwHotkey);
            void SetHotkey(short wHotkey);
            void GetShowCmd(out int piShowCmd);
            void SetShowCmd(int iShowCmd);
            void GetIconLocation([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, int cchIconPath, out int piIcon);
            void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);
            void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, int dwReserved);
            void Resolve(IntPtr hwnd, int fFlags);
            void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
        }
    }
}
