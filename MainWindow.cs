using Microsoft.Win32;
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

        const int
            PAGE_WLECOME = 0,
            PAGE_LICENCE = 1,
            PAGE_TOS = 2,
            PAGE_SETUP = 3,
            PAGE_INSTALL = 4;

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
            btnBack.Enabled = _step > PAGE_WLECOME && _step != PAGE_INSTALL;
            btnNext.Enabled = CanDoNext();
            btnCancel.Visible = _step == PAGE_WLECOME;
            btnReinstall.Visible = false;
            lbProgressError.Visible = false;
            if ("Setup".Equals(e.TabPage.Tag))
            {
                btnNext.Text = "Install";
            }
            else if ("Install".Equals(e.TabPage.Tag))
            {
                _installer.InstallDir = lbOutputPath.Text;
                if (_installer.Prepare())
                {
                    DoInstall();
                }
                else
                {
                    btnNext.Enabled = true;
                    lbProgress.Text = "Already installed";
                    prgTotal.Visible = false;
                    btnReinstall.Visible = true;
                }
                btnNext.Text = "Done";
            }
            else
            {
                btnNext.Text = "Next";
            }
        }

        private void DoInstall()
        {
            prgTotal.Visible = true;
            _installer.Run((ev) => this.BeginInvoke((MethodInvoker)delegate ()
            {
                Debug.WriteLine($"{ev.Message}");
                if (ev.IsError)
                {
                    lbProgressError.Visible = true;
                    lbProgressError.Text = ev.Message;
                }
                else
                {
                    lbProgressError.Visible = false;
                    lbProgress.Text = ev.Message;
                }
                if (ev.Total >= 0)
                {
                    prgTotal.Maximum = ev.Total;
                }
                if (ev.Step >= 0)
                {
                    prgTotal.Value = ev.Step;
                }
                btnNext.Enabled = ev.IsDone;
            }));
        }

        private void tabWizard_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = e.TabPageIndex != _step;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CommitPage(_step);
            SwitchTo(_step + 1);

        }

        private void CommitPage(int step)
        {
            switch (step)
            {
                case PAGE_TOS:
                    UpdateSentryFlag(chkSentry.Checked);
                    break;
            }
        }

        private void UpdateSentryFlag(bool sendReports)
        {
            using (var entry = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GolemFactory\ThorgMiner"))
            {
                entry.SetValue("sendReports", sendReports ? "yes" : "no");
            }
        }

        public bool GetSentryFlag()
        {
            using (var entry = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\GolemFactory\ThorgMiner"))
            {
                return entry == null || "yes" == entry?.GetValue("sendReports") as string;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SwitchTo(_step - 1);
        }


        private bool CanDoNext()
        {
            switch (_step)
            {
                case PAGE_WLECOME:
                    return true;
                case PAGE_LICENCE:
                    return chkLicense.Checked;
                case PAGE_TOS:
                    return chkToS.Checked;
                case PAGE_SETUP:
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

        private async void btnReinstall_Click(object sender, EventArgs e)
        {
            btnReinstall.Visible = false;
            btnNext.Enabled = false;
            var exePath = _installer.ThorgExePath;
            var processName = Path.GetFileNameWithoutExtension(exePath);
            for (var retry = 0; retry < 5; ++retry)
            {
                bool sendKill = false;
                foreach (var thorgProcess in Process.GetProcessesByName(processName))
                {
                    try
                    {
                        if (thorgProcess.MainModule.FileName == exePath)
                        {
                            thorgProcess.Kill();
                            sendKill = true;
                        }
                    }
                    catch (Win32Exception ex)
                    {
                        Debug.WriteLine($"unable to kill {thorgProcess}: {ex}");
                    }
                }
                if (sendKill)
                {
                    await Task.Delay(1000);
                }
                else
                {
                    break;
                }
            }

            DoInstall();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            chkSentry.Checked = GetSentryFlag();
        }

        private int _step = 0;
        private Installer _installer = new Installer(new Uri("https://golem-releases.cdn.golem.network/thorg/"));


    }
}
