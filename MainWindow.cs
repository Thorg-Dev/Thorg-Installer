using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thorg_Installer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Task.Run(async () =>
            {
                var app = await Config.App.Load();
                Debug.WriteLine("app= {0} / {1}", app.Name, app.Version);
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    lbVersion.Text = $"v{app.Version}";
                    lbOutputPath.Text = _installer.InstallDir;

                    Action<CheckBox, Config.Component> decorateComponent = (control, component) =>
                    {
                        if (component != null)
                        {
                            control.Text = $"{control.Text} v{component.Version}";
                        }
                    };
                    decorateComponent(chkCompYagna, app["yagna"]);
                    decorateComponent(chkCompThorg, app["thorg"]);
                    decorateComponent(chkCompWasi, app["wasi"]);
                    decorateComponent(chkCompGMiner, app["gminer"]);
                    _installer.Descriptor = app;
                    if (!_installer.Prepare())
                    {
                        SwitchTo(4);
                    }
                });
            });

        }

        private void tabWizard_Selected(object sender, TabControlEventArgs e)
        {
            btnBack.Enabled = _step > 0;
            btnNext.Enabled = CanDoNext();
            if (e.TabPage.Text == "Setup")
            {
                btnNext.Text = "Install";
            }
            else if (e.TabPage.Text == "Install")
            {
                _installer.InstallDir = lbOutputPath.Text;
                if (_installer.Prepare())
                {
                    _installer.Run((msg, step, total, done) => this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        Debug.WriteLine($"{msg} {step * 100 / total}%");
                        lbProgress.Text = msg;
                        prgTotal.Maximum = total;
                        prgTotal.Value = step;
                        btnNext.Enabled = done;
                    }));
                }
                btnNext.Text = "Done";
            }
            else
            {
                btnNext.Text = "Next";
            }
        }

        private void tabWizard_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = e.TabPageIndex != _step;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SwitchTo(_step + 1);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SwitchTo(_step - 1);
        }


        private bool CanDoNext()
        {
            switch (_step)
            {
                case 0:
                    return true;
                case 1:
                    return chkLicense.Checked;
                case 2:
                    return chkToS.Checked;
                case 3:
                    return chkLicense.Checked && chkToS.Checked;
                default:
                    return false;
            }

        }

        private void SwitchTo(int newStep)
        {
            if (newStep >= tabWizard.TabPages.Count)
            {
                Process.Start(new ProcessStartInfo()
                {
                    FileName = _installer.ThorgExePath,
                    WorkingDirectory = _installer.VersionPath
                });
                Close();
                return;
            }
            _step = newStep;
            tabWizard.SelectedIndex = _step;
        }

        private void ChkUpdate(object sender, EventArgs e)
        {
            btnNext.Enabled = CanDoNext();
        }

        private void btnBrowseLocation_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.ValidateNames = false;
            openFileDialog.CheckFileExists = false;
            openFileDialog.CheckPathExists = true;
            openFileDialog.FileName = "Folder Selection.";
            openFileDialog.InitialDirectory = lbOutputPath.Text;
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                lbOutputPath.Text = Path.GetDirectoryName(openFileDialog.FileName);
            }
        }

        private int _step = 0;
        private Installer _installer = new Installer(new Uri("https://golem-releases.cdn.golem.network/thorg/"));
    }
}
