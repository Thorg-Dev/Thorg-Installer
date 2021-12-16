using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Thorg_Installer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var app = new Config.App()
            {
                Name = "Thorg",
                Version = "0.0.0",
                Components =
                {
                    new Config.Component()
                    {
                        Id = "Test", Sha256="000"
                    }
                }
            };

            XmlSerializer xs = new XmlSerializer(typeof(Config.App));
            var tw = new System.IO.StringWriter();
            xs.Serialize(tw, app);
            Debug.WriteLine("out={0}", tw);

            using (var tr = System.IO.File.OpenText("f:\\thorg.xml"))
            {
                var app2 = xs.Deserialize(tr);
                tw = new System.IO.StringWriter();
                xs.Serialize(tw, app2);
                Debug.WriteLine("out={0}", tw);
            }               


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());

           
        }
    }
}
