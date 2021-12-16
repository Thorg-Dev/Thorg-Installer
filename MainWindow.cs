using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        }

        private void tabWizard_Selected(object sender, TabControlEventArgs e)
        {
            btnBack.Enabled = _step > 0;
            btnNext.Enabled = CanDoNext();
            if (e.TabPage.Text == "Setup")
            {
                btnNext.Text = "Install";
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
            _step = newStep;
            tabWizard.SelectedIndex = _step;            
        }

        private int _step = 0;

        private void ChkUpdate(object sender, EventArgs e)
        {
            btnNext.Enabled = CanDoNext();
        }
    }
}
