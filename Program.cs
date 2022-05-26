using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Thorg_Installer
{
    static class Program
    {
        public static bool UserIsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static bool RunElevated()
        {
            string args = string.Empty;
            string[] argsArray = Environment.GetCommandLineArgs();
            // First entry of the array must be ignored!
            for (int i = 1; i < argsArray.Length; i++)
            {
                if (!string.IsNullOrEmpty(args))
                    args += " ";
                args += argsArray[i];
            }
            return RunElevated(System.Windows.Forms.Application.ExecutablePath, args);
        }
        /// <summary>
        /// Restarts any application with admin rights.
        /// </summary>
        public static bool RunElevated(string fileName, string args)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.Verb = "runas";
            processInfo.FileName = fileName;
            processInfo.Arguments = args;
            try
            {
                Process.Start(processInfo);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (UserIsAdmin() == false)
            {
                if (RunElevated())
                {
                    Environment.Exit(0);
                }
            }
            Application.Run(new MainWindow());
        }
    }
}
