
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
            this.AddDefenderCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCompGMiner = new System.Windows.Forms.CheckBox();
            this.chkCompWasi = new System.Windows.Forms.CheckBox();
            this.chkCompThorg = new System.Windows.Forms.CheckBox();
            this.chkCompYagna = new System.Windows.Forms.CheckBox();
            this.btnBrowseLocation = new System.Windows.Forms.Button();
            this.lbOutputPath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabInstall = new System.Windows.Forms.TabPage();
            this.lbProgressError = new System.Windows.Forms.Label();
            this.lbProgress = new System.Windows.Forms.Label();
            this.prgTotal = new System.Windows.Forms.ProgressBar();
            this.tabUninstall = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cboUninstallConfiguration = new System.Windows.Forms.CheckBox();
            this.cboUninstallYagna = new System.Windows.Forms.CheckBox();
            this.DefenderRuleCheckbox = new System.Windows.Forms.CheckBox();
            this.btnConfirmUninstall = new System.Windows.Forms.Button();
            this.lblUninstallError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnRepair = new System.Windows.Forms.Button();
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
            this.tabInstall.SuspendLayout();
            this.tabUninstall.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(9, 9);
            richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(664, 367);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new System.Drawing.Point(4, 5);
            richTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new System.Drawing.Size(673, 321);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Thorg_Installer.Properties.Resources.app_logo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.pictureBox1.Size = new System.Drawing.Size(362, 528);
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
            this.tabWizard.Controls.Add(this.tabInstall);
            this.tabWizard.Controls.Add(this.tabUninstall);
            this.tabWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWizard.Location = new System.Drawing.Point(371, 9);
            this.tabWizard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabWizard.Name = "tabWizard";
            this.tabWizard.SelectedIndex = 0;
            this.tabWizard.Size = new System.Drawing.Size(696, 528);
            this.tabWizard.TabIndex = 1;
            this.tabWizard.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabWizard_Selecting);
            this.tabWizard.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabWizard_Selected);
            // 
            // tabPageWelcome
            // 
            this.tabPageWelcome.Controls.Add(this.groupBox2);
            this.tabPageWelcome.Location = new System.Drawing.Point(4, 32);
            this.tabPageWelcome.Margin = new System.Windows.Forms.Padding(9);
            this.tabPageWelcome.Name = "tabPageWelcome";
            this.tabPageWelcome.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageWelcome.Size = new System.Drawing.Size(688, 492);
            this.tabPageWelcome.TabIndex = 0;
            this.tabPageWelcome.Text = "1. Welcome";
            this.tabPageWelcome.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(675, 398);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 24);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(667, 369);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to the Thorg Miner Setup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 46, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Setup Wizard will install Thorg Miner on your computer.\r\nClik Next to Continu" +
    "e or Cancel to exit the Setup Wizard.\r\n";
            // 
            // tabLicense
            // 
            this.tabLicense.Controls.Add(this.chkLicense);
            this.tabLicense.Controls.Add(richTextBox1);
            this.tabLicense.Location = new System.Drawing.Point(4, 32);
            this.tabLicense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabLicense.Name = "tabLicense";
            this.tabLicense.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabLicense.Size = new System.Drawing.Size(688, 492);
            this.tabLicense.TabIndex = 2;
            this.tabLicense.Tag = "License";
            this.tabLicense.Text = "2. License";
            this.tabLicense.UseVisualStyleBackColor = true;
            // 
            // chkLicense
            // 
            this.chkLicense.AutoSize = true;
            this.chkLicense.Location = new System.Drawing.Point(9, 388);
            this.chkLicense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkLicense.Name = "chkLicense";
            this.chkLicense.Size = new System.Drawing.Size(321, 24);
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
            this.tabToS.Location = new System.Drawing.Point(4, 32);
            this.tabToS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabToS.Name = "tabToS";
            this.tabToS.Size = new System.Drawing.Size(688, 492);
            this.tabToS.TabIndex = 3;
            this.tabToS.Text = "3. Terms Of Service";
            this.tabToS.UseVisualStyleBackColor = true;
            // 
            // chkSentry
            // 
            this.chkSentry.AutoSize = true;
            this.chkSentry.Location = new System.Drawing.Point(24, 375);
            this.chkSentry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSentry.Name = "chkSentry";
            this.chkSentry.Size = new System.Drawing.Size(345, 24);
            this.chkSentry.TabIndex = 2;
            this.chkSentry.Text = "Automatically send application crash reports";
            this.chkSentry.UseVisualStyleBackColor = true;
            // 
            // chkToS
            // 
            this.chkToS.AutoSize = true;
            this.chkToS.Location = new System.Drawing.Point(24, 338);
            this.chkToS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkToS.Name = "chkToS";
            this.chkToS.Size = new System.Drawing.Size(298, 24);
            this.chkToS.TabIndex = 1;
            this.chkToS.Text = "Accept Golem Platform Terms of Use";
            this.chkToS.UseVisualStyleBackColor = true;
            this.chkToS.CheckedChanged += new System.EventHandler(this.ChkUpdate);
            // 
            // tabDestination
            // 
            this.tabDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDestination.Controls.Add(this.AddDefenderCheckbox);
            this.tabDestination.Controls.Add(this.groupBox1);
            this.tabDestination.Controls.Add(this.btnBrowseLocation);
            this.tabDestination.Controls.Add(this.lbOutputPath);
            this.tabDestination.Controls.Add(this.label3);
            this.tabDestination.Location = new System.Drawing.Point(4, 32);
            this.tabDestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDestination.Name = "tabDestination";
            this.tabDestination.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDestination.Size = new System.Drawing.Size(688, 492);
            this.tabDestination.TabIndex = 1;
            this.tabDestination.Text = "4. Setup";
            this.tabDestination.UseVisualStyleBackColor = true;
            // 
            // AddDefenderCheckbox
            // 
            this.AddDefenderCheckbox.AutoSize = true;
            this.AddDefenderCheckbox.Checked = true;
            this.AddDefenderCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddDefenderCheckbox.Location = new System.Drawing.Point(45, 352);
            this.AddDefenderCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddDefenderCheckbox.Name = "AddDefenderCheckbox";
            this.AddDefenderCheckbox.Size = new System.Drawing.Size(331, 24);
            this.AddDefenderCheckbox.TabIndex = 4;
            this.AddDefenderCheckbox.Text = "Add defender exception (Requires Admin)";
            this.AddDefenderCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCompGMiner);
            this.groupBox1.Controls.Add(this.chkCompWasi);
            this.groupBox1.Controls.Add(this.chkCompThorg);
            this.groupBox1.Controls.Add(this.chkCompYagna);
            this.groupBox1.Location = new System.Drawing.Point(45, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(494, 218);
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
            this.chkCompGMiner.Location = new System.Drawing.Point(28, 140);
            this.chkCompGMiner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCompGMiner.Name = "chkCompGMiner";
            this.chkCompGMiner.Size = new System.Drawing.Size(155, 24);
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
            this.chkCompWasi.Location = new System.Drawing.Point(28, 103);
            this.chkCompWasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCompWasi.Name = "chkCompWasi";
            this.chkCompWasi.Size = new System.Drawing.Size(125, 24);
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
            this.chkCompThorg.Location = new System.Drawing.Point(28, 66);
            this.chkCompThorg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCompThorg.Name = "chkCompThorg";
            this.chkCompThorg.Size = new System.Drawing.Size(97, 24);
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
            this.chkCompYagna.Location = new System.Drawing.Point(28, 29);
            this.chkCompYagna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCompYagna.Name = "chkCompYagna";
            this.chkCompYagna.Size = new System.Drawing.Size(207, 24);
            this.chkCompYagna.TabIndex = 0;
            this.chkCompYagna.Text = "Golem Provider Runtime";
            this.chkCompYagna.UseVisualStyleBackColor = true;
            // 
            // btnBrowseLocation
            // 
            this.btnBrowseLocation.Location = new System.Drawing.Point(548, 17);
            this.btnBrowseLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseLocation.Name = "btnBrowseLocation";
            this.btnBrowseLocation.Size = new System.Drawing.Size(112, 35);
            this.btnBrowseLocation.TabIndex = 2;
            this.btnBrowseLocation.Text = "B&rowse";
            this.btnBrowseLocation.UseVisualStyleBackColor = true;
            this.btnBrowseLocation.Click += new System.EventHandler(this.btnBrowseLocation_Click);
            // 
            // lbOutputPath
            // 
            this.lbOutputPath.AutoSize = true;
            this.lbOutputPath.Location = new System.Drawing.Point(138, 25);
            this.lbOutputPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOutputPath.Name = "lbOutputPath";
            this.lbOutputPath.Size = new System.Drawing.Size(387, 20);
            this.lbOutputPath.TabIndex = 1;
            this.lbOutputPath.Text = "C:\\Users\\golem-dev\\AppData\\Roaming\\GolemFactory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Location:";
            // 
            // tabInstall
            // 
            this.tabInstall.Controls.Add(this.lbProgressError);
            this.tabInstall.Controls.Add(this.lbProgress);
            this.tabInstall.Controls.Add(this.prgTotal);
            this.tabInstall.Location = new System.Drawing.Point(4, 32);
            this.tabInstall.Margin = new System.Windows.Forms.Padding(12);
            this.tabInstall.Name = "tabInstall";
            this.tabInstall.Size = new System.Drawing.Size(688, 492);
            this.tabInstall.TabIndex = 4;
            this.tabInstall.Tag = "Install";
            this.tabInstall.Text = "5 .Install";
            this.tabInstall.UseVisualStyleBackColor = true;
            // 
            // lbProgressError
            // 
            this.lbProgressError.AutoSize = true;
            this.lbProgressError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgressError.ForeColor = System.Drawing.Color.Red;
            this.lbProgressError.Location = new System.Drawing.Point(27, 195);
            this.lbProgressError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProgressError.Name = "lbProgressError";
            this.lbProgressError.Size = new System.Drawing.Size(72, 29);
            this.lbProgressError.TabIndex = 2;
            this.lbProgressError.Text = "Error";
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(32, 52);
            this.lbProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(0, 20);
            this.lbProgress.TabIndex = 1;
            // 
            // prgTotal
            // 
            this.prgTotal.Location = new System.Drawing.Point(32, 82);
            this.prgTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prgTotal.Name = "prgTotal";
            this.prgTotal.Size = new System.Drawing.Size(578, 35);
            this.prgTotal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgTotal.TabIndex = 0;
            this.prgTotal.Value = 100;
            // 
            // tabUninstall
            // 
            this.tabUninstall.Controls.Add(this.flowLayoutPanel3);
            this.tabUninstall.Location = new System.Drawing.Point(4, 32);
            this.tabUninstall.Name = "tabUninstall";
            this.tabUninstall.Padding = new System.Windows.Forms.Padding(3);
            this.tabUninstall.Size = new System.Drawing.Size(688, 492);
            this.tabUninstall.TabIndex = 5;
            this.tabUninstall.Text = "Uninstall";
            this.tabUninstall.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.checkBox1);
            this.flowLayoutPanel3.Controls.Add(this.cboUninstallConfiguration);
            this.flowLayoutPanel3.Controls.Add(this.cboUninstallYagna);
            this.flowLayoutPanel3.Controls.Add(this.DefenderRuleCheckbox);
            this.flowLayoutPanel3.Controls.Add(this.btnConfirmUninstall);
            this.flowLayoutPanel3.Controls.Add(this.lblUninstallError);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(682, 486);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(525, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "This will uninstall Thorg and its components";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 46, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(470, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choose which components you would like to remove from your PC";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(4, 126);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 31, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(219, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Thorg and its components";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cboUninstallConfiguration
            // 
            this.cboUninstallConfiguration.AutoSize = true;
            this.cboUninstallConfiguration.Location = new System.Drawing.Point(4, 160);
            this.cboUninstallConfiguration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboUninstallConfiguration.Name = "cboUninstallConfiguration";
            this.cboUninstallConfiguration.Size = new System.Drawing.Size(215, 24);
            this.cboUninstallConfiguration.TabIndex = 4;
            this.cboUninstallConfiguration.Text = "Thorg\'s configuration files";
            this.cboUninstallConfiguration.UseVisualStyleBackColor = true;
            this.cboUninstallConfiguration.CheckedChanged += new System.EventHandler(this.cboUninstallConfiguration_CheckedChanged);
            // 
            // cboUninstallYagna
            // 
            this.cboUninstallYagna.AutoSize = true;
            this.cboUninstallYagna.Location = new System.Drawing.Point(4, 194);
            this.cboUninstallYagna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboUninstallYagna.Name = "cboUninstallYagna";
            this.cboUninstallYagna.Size = new System.Drawing.Size(400, 24);
            this.cboUninstallYagna.TabIndex = 5;
            this.cboUninstallYagna.Text = "Yagna\'s configuration files  (including all wallet data)";
            this.cboUninstallYagna.UseVisualStyleBackColor = true;
            this.cboUninstallYagna.CheckedChanged += new System.EventHandler(this.cboUninstallYagna_CheckedChanged);
            // 
            // DefenderRuleCheckbox
            // 
            this.DefenderRuleCheckbox.AutoSize = true;
            this.DefenderRuleCheckbox.Location = new System.Drawing.Point(4, 228);
            this.DefenderRuleCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DefenderRuleCheckbox.Name = "DefenderRuleCheckbox";
            this.DefenderRuleCheckbox.Size = new System.Drawing.Size(352, 24);
            this.DefenderRuleCheckbox.TabIndex = 7;
            this.DefenderRuleCheckbox.Text = "Remove defender exception (requires admin)";
            this.DefenderRuleCheckbox.UseVisualStyleBackColor = true;
            // 
            // btnConfirmUninstall
            // 
            this.btnConfirmUninstall.AutoSize = true;
            this.btnConfirmUninstall.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmUninstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmUninstall.Location = new System.Drawing.Point(0, 288);
            this.btnConfirmUninstall.Margin = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.btnConfirmUninstall.MinimumSize = new System.Drawing.Size(0, 20);
            this.btnConfirmUninstall.Name = "btnConfirmUninstall";
            this.btnConfirmUninstall.Size = new System.Drawing.Size(674, 66);
            this.btnConfirmUninstall.TabIndex = 2;
            this.btnConfirmUninstall.Text = "Yes, I want to uninstall Thorg";
            this.btnConfirmUninstall.UseVisualStyleBackColor = true;
            this.btnConfirmUninstall.Click += new System.EventHandler(this.btnConfirmUninstall_Click);
            // 
            // lblUninstallError
            // 
            this.lblUninstallError.AutoSize = true;
            this.lblUninstallError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUninstallError.ForeColor = System.Drawing.Color.Red;
            this.lblUninstallError.Location = new System.Drawing.Point(4, 369);
            this.lblUninstallError.Margin = new System.Windows.Forms.Padding(4, 15, 4, 0);
            this.lblUninstallError.Name = "lblUninstallError";
            this.lblUninstallError.Size = new System.Drawing.Size(72, 29);
            this.lblUninstallError.TabIndex = 6;
            this.lblUninstallError.Text = "Error";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnUninstall);
            this.panel1.Controls.Add(this.btnRepair);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(371, 469);
            this.panel1.Margin = new System.Windows.Forms.Padding(9);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(90, 9, 90, 9);
            this.panel1.Size = new System.Drawing.Size(696, 68);
            this.panel1.TabIndex = 2;
            // 
            // btnUninstall
            // 
            this.btnUninstall.AllowDrop = true;
            this.btnUninstall.Location = new System.Drawing.Point(135, 9);
            this.btnUninstall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(112, 48);
            this.btnUninstall.TabIndex = 4;
            this.btnUninstall.Text = "Uninstall";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Visible = false;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.Location = new System.Drawing.Point(14, 9);
            this.btnRepair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(112, 48);
            this.btnRepair.TabIndex = 2;
            this.btnRepair.Text = "Repair";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Visible = false;
            this.btnRepair.Click += new System.EventHandler(this.btnReinstall_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Location = new System.Drawing.Point(570, 14);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 48);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(280, 14);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(282, 48);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.MinimumSize = new System.Drawing.Size(0, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 48);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNext.Location = new System.Drawing.Point(135, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.MinimumSize = new System.Drawing.Size(0, 20);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 48);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(156, 280);
            this.lbVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(64, 20);
            this.lbVersion.TabIndex = 3;
            this.lbVersion.Text = "v0.0.0.0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 546);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabWizard);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(9);
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
            this.tabInstall.ResumeLayout(false);
            this.tabInstall.PerformLayout();
            this.tabUninstall.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.TabPage tabInstall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.ProgressBar prgTotal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.Label lbProgressError;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.TabPage tabUninstall;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox cboUninstallConfiguration;
        private System.Windows.Forms.Button btnConfirmUninstall;
        private System.Windows.Forms.CheckBox cboUninstallYagna;
        private System.Windows.Forms.Label lblUninstallError;
        private System.Windows.Forms.CheckBox DefenderRuleCheckbox;
        private System.Windows.Forms.CheckBox AddDefenderCheckbox;
    }
}
