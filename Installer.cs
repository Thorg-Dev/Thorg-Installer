using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Thorg_Installer.Config;

namespace Thorg_Installer
{
    /// <summary>
    /// General instalation logic
    /// </summary>
    class Installer
    {
        public Uri BaseUri { get; private set; }
        public App Descriptor { get; set; }

        public string InstallDir { get; set; }

        private Component[] _downloads = null;

        private string CachePath => Path.Combine(InstallDir, "cache");

        public string VersionPath => Path.Combine(InstallDir, $"v{Descriptor.Version}");

        public string ThorgExePath => Path.Combine(VersionPath, "ThorgMiner.exe");

        public Installer(Uri baseUri)
        {
            BaseUri = baseUri;
            InstallDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Thorg");
        }

        public bool Prepare()
        {
            var currentDescriptorPath = Path.Combine(InstallDir, @"thorg.xml");
            if (File.Exists(currentDescriptorPath))
            {
                var currentDescriptor = App.FromFile(currentDescriptorPath);
                var diff = Descriptor.DiffrenceTo(currentDescriptor);
                if (diff.Count == 0)
                {
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

        public void Run(Action<string, int, int, bool> progress)
        {
            Task.Run(() =>
            {
                var allComponents = Descriptor.GetAllComponents();
                int step = 0;
                int total = _downloads.Length + allComponents.Count + 1;
                progress?.Invoke("Createing Directories", ++step, total, false);

                CreatePaths();
                var cache = CachePath;
                foreach (var c in _downloads)
                {
                    using (var client = new WebClient())
                    {
                        progress?.Invoke($"Downloading {c.Download}", ++step, total, false);
                        client.DownloadFile(new Uri(BaseUri, c.Download), Path.Combine(cache, $"{c.Download}.zip"));
                    }
                }
                var outputDir = VersionPath;
                foreach (var c in Descriptor.GetAllComponents())
                {
                    progress?.Invoke($"Extracting {c.Download}", ++step, total, false);
                    ZipFile.ExtractToDirectory(Path.Combine(cache, $"{c.Download}.zip"), outputDir);
                }
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
                progress?.Invoke($"Done", total, total, true);
            });
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
