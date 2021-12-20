
namespace Thorg_Installer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.RichTextBox richTextBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.RichTextBox richTextBox2;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabWizard = new System.Windows.Forms.TabControl();
            this.tabPageWelcome = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLicense = new System.Windows.Forms.TabPage();
            this.chkLicense = new System.Windows.Forms.CheckBox();
            this.tabToS = new System.Windows.Forms.TabPage();
            this.chkSentry = new System.Windows.Forms.CheckBox();
            this.chkToS = new System.Windows.Forms.CheckBox();
            this.tabDestination = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCompGMiner = new System.Windows.Forms.CheckBox();
            this.chkCompWasi = new System.Windows.Forms.CheckBox();
            this.chkCompThorg = new System.Windows.Forms.CheckBox();
            this.chkCompYagna = new System.Windows.Forms.CheckBox();
            this.btnBrowseLocation = new System.Windows.Forms.Button();
            this.lbOutputPath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbProgressError = new System.Windows.Forms.Label();
            this.lbProgress = new System.Windows.Forms.Label();
            this.prgTotal = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReinstall = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbVersion = new System.Windows.Forms.Label();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabWizard.SuspendLayout();
            this.tabPageWelcome.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabLicense.SuspendLayout();
            this.tabToS.SuspendLayout();
            this.tabDestination.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            //
            // richTextBox1
            //
            richTextBox1.Location = new System.Drawing.Point(6, 6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(444, 240);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            //
            // richTextBox2
            //
            richTextBox2.Location = new System.Drawing.Point(3, 3);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new System.Drawing.Size(450, 210);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            //
            // pictureBox1
            //
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Thorg_Installer.Properties.Resources.app_logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(20, 60, 20, 20);
            this.pictureBox1.Size = new System.Drawing.Size(241, 343);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            //
            // tabWizard
            //
            this.tabWizard.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabWizard.Controls.Add(this.tabPageWelcome);
            this.tabWizard.Controls.Add(this.tabLicense);
            this.tabWizard.Controls.Add(this.tabToS);
            this.tabWizard.Controls.Add(this.tabDestination);
            this.tabWizard.Controls.Add(this.tabPage1);
            this.tabWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWizard.Location = new System.Drawing.Point(247, 6);
            this.tabWizard.Name = "tabWizard";
            this.tabWizard.SelectedIndex = 0;
            this.tabWizard.Size = new System.Drawing.Size(464, 343);
            this.tabWizard.TabIndex = 1;
            this.tabWizard.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabWizard_Selecting);
            this.tabWizard.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabWizard_Selected);
            //
            // tabPageWelcome
            //
            this.tabPageWelcome.Controls.Add(this.groupBox2);
            this.tabPageWelcome.Location = new System.Drawing.Point(4, 25);
            this.tabPageWelcome.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageWelcome.Name = "tabPageWelcome";
            this.tabPageWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWelcome.Size = new System.Drawing.Size(456, 314);
            this.tabPageWelcome.TabIndex = 0;
            this.tabPageWelcome.Text = "1. Welcome";
            this.tabPageWelcome.UseVisualStyleBackColor = true;
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 259);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            //
            // flowLayoutPanel2
            //
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(444, 240);
            this.flowLayoutPanel2.TabIndex = 0;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to the Thorg Miner Setup";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Setup Wizard will install Thorg Miner on your computer.\r\nClik Next to Continu" +
    "e or Cancel to exit the Setup Wizard.\r\n";
            //
            // tabLicense
            //
            this.tabLicense.Controls.Add(this.chkLicense);
            this.tabLicense.Controls.Add(richTextBox1);
            this.tabLicense.Location = new System.Drawing.Point(4, 25);
            this.tabLicense.Name = "tabLicense";
            this.tabLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tabLicense.Size = new System.Drawing.Size(456, 314);
            this.tabLicense.TabIndex = 2;
            this.tabLicense.Tag = "License";
            this.tabLicense.Text = "2. License";
            this.tabLicense.UseVisualStyleBackColor = true;
            //
            // chkLicense
            //
            this.chkLicense.AutoSize = true;
            this.chkLicense.Location = new System.Drawing.Point(6, 252);
            this.chkLicense.Name = "chkLicense";
            this.chkLicense.Size = new System.Drawing.Size(216, 17);
            this.chkLicense.TabIndex = 1;
            this.chkLicense.Text = "I accept the terms in License Agreement";
            this.chkLicense.UseVisualStyleBackColor = true;
            this.chkLicense.CheckedChanged += new System.EventHandler(this.ChkUpdate);
            //
            // tabToS
            //
            this.tabToS.Controls.Add(this.chkSentry);
            this.tabToS.Controls.Add(this.chkToS);
            this.tabToS.Controls.Add(richTextBox2);
            this.tabToS.Location = new System.Drawing.Point(4, 25);
            this.tabToS.Name = "tabToS";
            this.tabToS.Size = new System.Drawing.Size(456, 314);
            this.tabToS.TabIndex = 3;
            this.tabToS.Text = "3. Terms Of Service";
            this.tabToS.UseVisualStyleBackColor = true;
            //
            // chkSentry
            //
            this.chkSentry.AutoSize = true;
            this.chkSentry.Location = new System.Drawing.Point(16, 244);
            this.chkSentry.Name = "chkSentry";
            this.chkSentry.Size = new System.Drawing.Size(232, 17);
            this.chkSentry.TabIndex = 2;
            this.chkSentry.Text = "Automatically send application crash reports";
            this.chkSentry.UseVisualStyleBackColor = true;
            //
            // chkToS
            //
            this.chkToS.AutoSize = true;
            this.chkToS.Location = new System.Drawing.Point(16, 220);
            this.chkToS.Name = "chkToS";
            this.chkToS.Size = new System.Drawing.Size(200, 17);
            this.chkToS.TabIndex = 1;
            this.chkToS.Text = "Accept Golem Platform Terms of Use";
            this.chkToS.UseVisualStyleBackColor = true;
            this.chkToS.CheckedChanged += new System.EventHandler(this.ChkUpdate);
            //
            // tabDestination
            //
            this.tabDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDestination.Controls.Add(this.groupBox1);
            this.tabDestination.Controls.Add(this.btnBrowseLocation);
            this.tabDestination.Controls.Add(this.lbOutputPath);
            this.tabDestination.Controls.Add(this.label3);
            this.tabDestination.Location = new System.Drawing.Point(4, 25);
            this.tabDestination.Name = "tabDestination";
            this.tabDestination.Padding = new System.Windows.Forms.Padding(3);
            this.tabDestination.Size = new System.Drawing.Size(456, 314);
            this.tabDestination.TabIndex = 1;
            this.tabDestination.Text = "4. Setup";
            this.tabDestination.UseVisualStyleBackColor = true;
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.chkCompGMiner);
            this.groupBox1.Controls.Add(this.chkCompWasi);
            this.groupBox1.Controls.Add(this.chkCompThorg);
            this.groupBox1.Controls.Add(this.chkCompYagna);
            this.groupBox1.Location = new System.Drawing.Point(30, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Components";
            //
            // chkCompGMiner
            //
            this.chkCompGMiner.AutoSize = true;
            this.chkCompGMiner.Checked = true;
            this.chkCompGMiner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompGMiner.Enabled = false;
            this.chkCompGMiner.Location = new System.Drawing.Point(19, 91);
            this.chkCompGMiner.Name = "chkCompGMiner";
            this.chkCompGMiner.Size = new System.Drawing.Size(106, 17);
            this.chkCompGMiner.TabIndex = 3;
            this.chkCompGMiner.Text = "Eth mining Driver";
            this.chkCompGMiner.UseVisualStyleBackColor = true;
            //
            // chkCompWasi
            //
            this.chkCompWasi.AutoSize = true;
            this.chkCompWasi.Checked = true;
            this.chkCompWasi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompWasi.Enabled = false;
            this.chkCompWasi.Location = new System.Drawing.Point(19, 67);
            this.chkCompWasi.Name = "chkCompWasi";
            this.chkCompWasi.Size = new System.Drawing.Size(87, 17);
            this.chkCompWasi.TabIndex = 2;
            this.chkCompWasi.Text = "Wasm Driver";
            this.chkCompWasi.UseVisualStyleBackColor = true;
            //
            // chkCompThorg
            //
            this.chkCompThorg.AutoSize = true;
            this.chkCompThorg.Checked = true;
            this.chkCompThorg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompThorg.Enabled = false;
            this.chkCompThorg.Location = new System.Drawing.Point(19, 43);
            this.chkCompThorg.Name = "chkCompThorg";
            this.chkCompThorg.Size = new System.Drawing.Size(68, 17);
            this.chkCompThorg.TabIndex = 1;
            this.chkCompThorg.Text = "Thorg UI";
            this.chkCompThorg.UseVisualStyleBackColor = true;
            //
            // chkCompYagna
            //
            this.chkCompYagna.AutoSize = true;
            this.chkCompYagna.Checked = true;
            this.chkCompYagna.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompYagna.Enabled = false;
            this.chkCompYagna.Location = new System.Drawing.Point(19, 19);
            this.chkCompYagna.Name = "chkCompYagna";
            this.chkCompYagna.Size = new System.Drawing.Size(140, 17);
            this.chkCompYagna.TabIndex = 0;
            this.chkCompYagna.Text = "Golem Provider Runtime";
            this.chkCompYagna.UseVisualStyleBackColor = true;
            //
            // btnBrowseLocation
            //
            this.btnBrowseLocation.Location = new System.Drawing.Point(365, 11);
            this.btnBrowseLocation.Name = "btnBrowseLocation";
            this.btnBrowseLocation.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLocation.TabIndex = 2;
            this.btnBrowseLocation.Text = "B&rowse";
            this.btnBrowseLocation.UseVisualStyleBackColor = true;
            this.btnBrowseLocation.Click += new System.EventHandler(this.btnBrowseLocation_Click);
            //
            // lbOutputPath
            //
            this.lbOutputPath.AutoSize = true;
            this.lbOutputPath.Location = new System.Drawing.Point(92, 16);
            this.lbOutputPath.Name = "lbOutputPath";
            this.lbOutputPath.Size = new System.Drawing.Size(267, 13);
            this.lbOutputPath.TabIndex = 1;
            this.lbOutputPath.Text = "C:\\Users\\golem-dev\\AppData\\Roaming\\GolemFactory";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Location:";
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.lbProgressError);
            this.tabPage1.Controls.Add(this.lbProgress);
            this.tabPage1.Controls.Add(this.prgTotal);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(456, 314);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Tag = "Install";
            this.tabPage1.Text = "5 .Install";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // lbProgressError
            //
            this.lbProgressError.AutoSize = true;
            this.lbProgressError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgressError.ForeColor = System.Drawing.Color.Red;
            this.lbProgressError.Location = new System.Drawing.Point(18, 127);
            this.lbProgressError.Name = "lbProgressError";
            this.lbProgressError.Size = new System.Drawing.Size(47, 18);
            this.lbProgressError.TabIndex = 2;
            this.lbProgressError.Text = "Error";
            //
            // lbProgress
            //
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(21, 34);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(0, 13);
            this.lbProgress.TabIndex = 1;
            //
            // prgTotal
            //
            this.prgTotal.Location = new System.Drawing.Point(21, 53);
            this.prgTotal.Name = "prgTotal";
            this.prgTotal.Size = new System.Drawing.Size(385, 23);
            this.prgTotal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgTotal.TabIndex = 0;
            this.prgTotal.Value = 100;
            //
            // panel1
            //
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnReinstall);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(247, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(60, 6, 60, 6);
            this.panel1.Size = new System.Drawing.Size(464, 44);
            this.panel1.TabIndex = 2;
            //
            // btnReinstall
            //
            this.btnReinstall.Location = new System.Drawing.Point(16, 9);
            this.btnReinstall.Name = "btnReinstall";
            this.btnReinstall.Size = new System.Drawing.Size(75, 31);
            this.btnReinstall.TabIndex = 2;
            this.btnReinstall.Text = "Reinstall";
            this.btnReinstall.UseVisualStyleBackColor = true;
            this.btnReinstall.Visible = false;
            this.btnReinstall.Click += new System.EventHandler(this.btnReinstall_Click);
            //
            // btnCancel
            //
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Location = new System.Drawing.Point(370, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            //
            // flowLayoutPanel1
            //
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnBack);
            this.flowLayoutPanel1.Controls.Add(this.btnNext);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(126, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(238, 31);
            this.flowLayoutPanel1.TabIndex = 2;
            //
            // btnBack
            //
            this.btnBack.AutoSize = true;
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.MinimumSize = new System.Drawing.Size(0, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 31);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            //
            // btnNext
            //
            this.btnNext.AutoSize = true;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNext.Location = new System.Drawing.Point(90, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.MinimumSize = new System.Drawing.Size(0, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 31);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            //
            // lbVersion
            //
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(104, 182);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(46, 13);
            this.lbVersion.TabIndex = 3;
            this.lbVersion.Text = "v0.0.0.0";
            //
            // MainWindow
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 355);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabWizard);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "[Thorg Installer]";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabWizard.ResumeLayout(false);
            this.tabPageWelcome.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabLicense.ResumeLayout(false);
            this.tabLicense.PerformLayout();
            this.tabToS.ResumeLayout(false);
            this.tabToS.PerformLayout();
            this.tabDestination.ResumeLayout(false);
            this.tabDestination.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabWizard;
        private System.Windows.Forms.TabPage tabPageWelcome;
        private System.Windows.Forms.TabPage tabDestination;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tabLicense;
        private System.Windows.Forms.TabPage tabToS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkLicense;
        private System.Windows.Forms.CheckBox chkSentry;
        private System.Windows.Forms.CheckBox chkToS;
        private System.Windows.Forms.Button btnBrowseLocation;
        private System.Windows.Forms.Label lbOutputPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCompGMiner;
        private System.Windows.Forms.CheckBox chkCompWasi;
        private System.Windows.Forms.CheckBox chkCompThorg;
        private System.Windows.Forms.CheckBox chkCompYagna;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.ProgressBar prgTotal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReinstall;
        private System.Windows.Forms.Label lbProgressError;
    }
}
