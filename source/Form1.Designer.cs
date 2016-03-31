namespace Rsa_algo
{
    partial class rsaApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rsaApp));
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.savediag = new System.Windows.Forms.SaveFileDialog();
            this.ofdiag = new System.Windows.Forms.OpenFileDialog();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mKey = new System.Windows.Forms.ToolStripMenuItem();
            this.mKeyExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mKeySend = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnFlush = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tbPublicKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrivateKey = new System.Windows.Forms.TextBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.tbKeySize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxSettings = new System.Windows.Forms.GroupBox();
            this.chOptimalPadding = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLogName = new System.Windows.Forms.TextBox();
            this.tbLogPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chLogs = new System.Windows.Forms.CheckBox();
            this.boxAbout = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbGithub = new System.Windows.Forms.LinkLabel();
            this.tbAbout = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.tbLoad = new System.Windows.Forms.TextBox();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.tabChoice = new System.Windows.Forms.TabControl();
            this.tabText = new System.Windows.Forms.TabPage();
            this.tabFile = new System.Windows.Forms.TabPage();
            this.tbLoadResult = new System.Windows.Forms.TextBox();
            this.boxHelp = new System.Windows.Forms.GroupBox();
            this.tbHelp = new System.Windows.Forms.TextBox();
            this.btnSettingsHelp = new System.Windows.Forms.Button();
            this.btnGuideHelp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.boxSettings.SuspendLayout();
            this.boxAbout.SuspendLayout();
            this.tabChoice.SuspendLayout();
            this.tabText.SuspendLayout();
            this.tabFile.SuspendLayout();
            this.boxHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(56, 28);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbKey.Size = new System.Drawing.Size(437, 60);
            this.tbKey.TabIndex = 4;
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.Control;
            this.tbResult.Location = new System.Drawing.Point(53, 172);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(437, 60);
            this.tbResult.TabIndex = 5;
            // 
            // savediag
            // 
            this.savediag.FileName = "Key.rsa";
            // 
            // ofdiag
            // 
            this.ofdiag.Tag = "";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(26, 43);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(484, 22);
            this.pb.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mKey,
            this.mHelp,
            this.mSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mKey
            // 
            this.mKey.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mKeyExport,
            this.mKeySend});
            this.mKey.Name = "mKey";
            this.mKey.Size = new System.Drawing.Size(38, 20);
            this.mKey.Text = "Key";
            // 
            // mKeyExport
            // 
            this.mKeyExport.Name = "mKeyExport";
            this.mKeyExport.Size = new System.Drawing.Size(107, 22);
            this.mKeyExport.Text = "Export";
            this.mKeyExport.Click += new System.EventHandler(this.mKeyExport_Click);
            // 
            // mKeySend
            // 
            this.mKeySend.Name = "mKeySend";
            this.mKeySend.Size = new System.Drawing.Size(107, 22);
            this.mKeySend.Text = "Send";
            this.mKeySend.Click += new System.EventHandler(this.mKeySend_Click);
            // 
            // mHelp
            // 
            this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mViewHelp,
            this.mAbout});
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(44, 20);
            this.mHelp.Text = "Help";
            // 
            // mViewHelp
            // 
            this.mViewHelp.Name = "mViewHelp";
            this.mViewHelp.Size = new System.Drawing.Size(152, 22);
            this.mViewHelp.Text = "View help";
            this.mViewHelp.Click += new System.EventHandler(this.mViewHelp_Click);
            // 
            // mAbout
            // 
            this.mAbout.Name = "mAbout";
            this.mAbout.Size = new System.Drawing.Size(152, 22);
            this.mAbout.Text = "About";
            this.mAbout.Click += new System.EventHandler(this.mAbout_Click);
            // 
            // mSettings
            // 
            this.mSettings.Name = "mSettings";
            this.mSettings.Size = new System.Drawing.Size(61, 20);
            this.mSettings.Text = "Settings";
            this.mSettings.Click += new System.EventHandler(this.mSettings_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(126, 114);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(103, 38);
            this.btnEncrypt.TabIndex = 13;
            this.btnEncrypt.Text = "Encryption";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(265, 114);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(103, 38);
            this.btnDecrypt.TabIndex = 14;
            this.btnDecrypt.Text = "Decryption";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnFlush
            // 
            this.btnFlush.Location = new System.Drawing.Point(6, 28);
            this.btnFlush.Name = "btnFlush";
            this.btnFlush.Size = new System.Drawing.Size(41, 23);
            this.btnFlush.TabIndex = 15;
            this.btnFlush.Text = "Flush";
            this.btnFlush.UseVisualStyleBackColor = true;
            this.btnFlush.Click += new System.EventHandler(this.btnFlush_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(6, 172);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(41, 23);
            this.btnCopy.TabIndex = 16;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tbPublicKey
            // 
            this.tbPublicKey.Location = new System.Drawing.Point(295, 117);
            this.tbPublicKey.Name = "tbPublicKey";
            this.tbPublicKey.Size = new System.Drawing.Size(215, 20);
            this.tbPublicKey.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(230, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Public key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(226, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Private key:";
            // 
            // tbPrivateKey
            // 
            this.tbPrivateKey.Location = new System.Drawing.Point(295, 171);
            this.tbPrivateKey.Name = "tbPrivateKey";
            this.tbPrivateKey.Size = new System.Drawing.Size(215, 20);
            this.tbPrivateKey.TabIndex = 20;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(58, 129);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(125, 43);
            this.btnInit.TabIndex = 21;
            this.btnInit.Text = "Initialize";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // tbKeySize
            // 
            this.tbKeySize.Location = new System.Drawing.Point(61, 27);
            this.tbKeySize.Name = "tbKeySize";
            this.tbKeySize.Size = new System.Drawing.Size(73, 20);
            this.tbKeySize.TabIndex = 22;
            this.tbKeySize.Text = "1024";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Key size:";
            // 
            // boxSettings
            // 
            this.boxSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boxSettings.Controls.Add(this.chOptimalPadding);
            this.boxSettings.Controls.Add(this.label5);
            this.boxSettings.Controls.Add(this.tbLogName);
            this.boxSettings.Controls.Add(this.tbLogPath);
            this.boxSettings.Controls.Add(this.label4);
            this.boxSettings.Controls.Add(this.chLogs);
            this.boxSettings.Controls.Add(this.label1);
            this.boxSettings.Controls.Add(this.tbKeySize);
            this.boxSettings.Location = new System.Drawing.Point(95, 27);
            this.boxSettings.Name = "boxSettings";
            this.boxSettings.Size = new System.Drawing.Size(194, 160);
            this.boxSettings.TabIndex = 24;
            this.boxSettings.TabStop = false;
            this.boxSettings.Text = "Settings";
            this.boxSettings.Visible = false;
            // 
            // chOptimalPadding
            // 
            this.chOptimalPadding.AutoSize = true;
            this.chOptimalPadding.Location = new System.Drawing.Point(73, 67);
            this.chOptimalPadding.Name = "chOptimalPadding";
            this.chOptimalPadding.Size = new System.Drawing.Size(122, 17);
            this.chOptimalPadding.TabIndex = 29;
            this.chOptimalPadding.Text = "Use optimal padding";
            this.chOptimalPadding.UseVisualStyleBackColor = true;
            this.chOptimalPadding.CheckedChanged += new System.EventHandler(this.chOptimalPadding_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Log name:";
            // 
            // tbLogName
            // 
            this.tbLogName.Location = new System.Drawing.Point(61, 125);
            this.tbLogName.Name = "tbLogName";
            this.tbLogName.ReadOnly = true;
            this.tbLogName.Size = new System.Drawing.Size(112, 20);
            this.tbLogName.TabIndex = 27;
            // 
            // tbLogPath
            // 
            this.tbLogPath.Location = new System.Drawing.Point(61, 90);
            this.tbLogPath.Name = "tbLogPath";
            this.tbLogPath.ReadOnly = true;
            this.tbLogPath.Size = new System.Drawing.Size(112, 20);
            this.tbLogPath.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Log path:";
            // 
            // chLogs
            // 
            this.chLogs.AutoSize = true;
            this.chLogs.Location = new System.Drawing.Point(9, 67);
            this.chLogs.Name = "chLogs";
            this.chLogs.Size = new System.Drawing.Size(67, 17);
            this.chLogs.TabIndex = 0;
            this.chLogs.Text = "Use logs";
            this.chLogs.UseVisualStyleBackColor = true;
            this.chLogs.CheckedChanged += new System.EventHandler(this.chLogs_CheckedChanged);
            // 
            // boxAbout
            // 
            this.boxAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boxAbout.Controls.Add(this.label7);
            this.boxAbout.Controls.Add(this.label6);
            this.boxAbout.Controls.Add(this.lbGithub);
            this.boxAbout.Controls.Add(this.tbAbout);
            this.boxAbout.Location = new System.Drawing.Point(46, 27);
            this.boxAbout.Name = "boxAbout";
            this.boxAbout.Size = new System.Drawing.Size(253, 173);
            this.boxAbout.TabIndex = 30;
            this.boxAbout.TabStop = false;
            this.boxAbout.Text = "About";
            this.boxAbout.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "E-mail: timurdelimin@gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Author: Elimination";
            // 
            // lbGithub
            // 
            this.lbGithub.AutoSize = true;
            this.lbGithub.Location = new System.Drawing.Point(8, 132);
            this.lbGithub.Name = "lbGithub";
            this.lbGithub.Size = new System.Drawing.Size(85, 13);
            this.lbGithub.TabIndex = 26;
            this.lbGithub.TabStop = true;
            this.lbGithub.Text = "RSA-Algo github";
            this.lbGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbGithub_LinkClicked);
            // 
            // tbAbout
            // 
            this.tbAbout.Location = new System.Drawing.Point(11, 20);
            this.tbAbout.Multiline = true;
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.ReadOnly = true;
            this.tbAbout.Size = new System.Drawing.Size(232, 105);
            this.tbAbout.TabIndex = 25;
            this.tbAbout.Text = "RSA-Algo it\'s open source programm. \r\nIt\'s used RSA algorithm for en/de-cryption " +
    "text and files. \r\nAlso you can send encrypted key to somebody.\r\nIf you want to h" +
    "elp us - just click link below.";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(32, 42);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 33);
            this.btnLoadFile.TabIndex = 25;
            this.btnLoadFile.Text = "Load";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // tbLoad
            // 
            this.tbLoad.Location = new System.Drawing.Point(113, 49);
            this.tbLoad.Name = "tbLoad";
            this.tbLoad.ReadOnly = true;
            this.tbLoad.Size = new System.Drawing.Size(351, 20);
            this.tbLoad.TabIndex = 26;
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.Location = new System.Drawing.Point(126, 114);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(103, 38);
            this.btnEncryptFile.TabIndex = 27;
            this.btnEncryptFile.Text = "Encryption";
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            this.btnEncryptFile.Click += new System.EventHandler(this.btnEncryptFile_Click);
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Location = new System.Drawing.Point(265, 114);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(103, 38);
            this.btnDecryptFile.TabIndex = 28;
            this.btnDecryptFile.Text = "Decryption";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            // 
            // tabChoice
            // 
            this.tabChoice.Controls.Add(this.tabText);
            this.tabChoice.Controls.Add(this.tabFile);
            this.tabChoice.Location = new System.Drawing.Point(26, 241);
            this.tabChoice.Name = "tabChoice";
            this.tabChoice.SelectedIndex = 0;
            this.tabChoice.Size = new System.Drawing.Size(507, 280);
            this.tabChoice.TabIndex = 29;
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.tbKey);
            this.tabText.Controls.Add(this.btnFlush);
            this.tabText.Controls.Add(this.btnEncrypt);
            this.tabText.Controls.Add(this.btnDecrypt);
            this.tabText.Controls.Add(this.tbResult);
            this.tabText.Controls.Add(this.btnCopy);
            this.tabText.Location = new System.Drawing.Point(4, 22);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(3);
            this.tabText.Size = new System.Drawing.Size(499, 254);
            this.tabText.TabIndex = 0;
            this.tabText.Text = "Text";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // tabFile
            // 
            this.tabFile.Controls.Add(this.tbLoadResult);
            this.tabFile.Controls.Add(this.tbLoad);
            this.tabFile.Controls.Add(this.btnDecryptFile);
            this.tabFile.Controls.Add(this.btnLoadFile);
            this.tabFile.Controls.Add(this.btnEncryptFile);
            this.tabFile.Location = new System.Drawing.Point(4, 22);
            this.tabFile.Name = "tabFile";
            this.tabFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabFile.Size = new System.Drawing.Size(499, 254);
            this.tabFile.TabIndex = 1;
            this.tabFile.Text = "File";
            this.tabFile.UseVisualStyleBackColor = true;
            // 
            // tbLoadResult
            // 
            this.tbLoadResult.Location = new System.Drawing.Point(16, 178);
            this.tbLoadResult.Multiline = true;
            this.tbLoadResult.Name = "tbLoadResult";
            this.tbLoadResult.ReadOnly = true;
            this.tbLoadResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLoadResult.Size = new System.Drawing.Size(464, 57);
            this.tbLoadResult.TabIndex = 29;
            // 
            // boxHelp
            // 
            this.boxHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boxHelp.Controls.Add(this.btnGuideHelp);
            this.boxHelp.Controls.Add(this.btnSettingsHelp);
            this.boxHelp.Controls.Add(this.tbHelp);
            this.boxHelp.Location = new System.Drawing.Point(46, 27);
            this.boxHelp.Name = "boxHelp";
            this.boxHelp.Size = new System.Drawing.Size(238, 195);
            this.boxHelp.TabIndex = 31;
            this.boxHelp.TabStop = false;
            this.boxHelp.Text = "Help";
            this.boxHelp.Visible = false;
            // 
            // tbHelp
            // 
            this.tbHelp.Location = new System.Drawing.Point(11, 58);
            this.tbHelp.Multiline = true;
            this.tbHelp.Name = "tbHelp";
            this.tbHelp.ReadOnly = true;
            this.tbHelp.Size = new System.Drawing.Size(215, 117);
            this.tbHelp.TabIndex = 25;
            // 
            // btnSettingsHelp
            // 
            this.btnSettingsHelp.Location = new System.Drawing.Point(24, 23);
            this.btnSettingsHelp.Name = "btnSettingsHelp";
            this.btnSettingsHelp.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsHelp.TabIndex = 26;
            this.btnSettingsHelp.Text = "Settings";
            this.btnSettingsHelp.UseVisualStyleBackColor = true;
            this.btnSettingsHelp.Click += new System.EventHandler(this.btnSettingsHelp_Click);
            // 
            // btnGuideHelp
            // 
            this.btnGuideHelp.Location = new System.Drawing.Point(134, 23);
            this.btnGuideHelp.Name = "btnGuideHelp";
            this.btnGuideHelp.Size = new System.Drawing.Size(75, 23);
            this.btnGuideHelp.TabIndex = 27;
            this.btnGuideHelp.Text = "Guide";
            this.btnGuideHelp.UseVisualStyleBackColor = true;
            this.btnGuideHelp.Click += new System.EventHandler(this.btnGuideHelp_Click);
            // 
            // rsaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Rsa_algo.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 540);
            this.Controls.Add(this.boxHelp);
            this.Controls.Add(this.boxAbout);
            this.Controls.Add(this.tabChoice);
            this.Controls.Add(this.boxSettings);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.tbPrivateKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPublicKey);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "rsaApp";
            this.Opacity = 0.92D;
            this.Text = "RSA Algo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.boxSettings.ResumeLayout(false);
            this.boxSettings.PerformLayout();
            this.boxAbout.ResumeLayout(false);
            this.boxAbout.PerformLayout();
            this.tabChoice.ResumeLayout(false);
            this.tabText.ResumeLayout(false);
            this.tabText.PerformLayout();
            this.tabFile.ResumeLayout(false);
            this.tabFile.PerformLayout();
            this.boxHelp.ResumeLayout(false);
            this.boxHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.SaveFileDialog savediag;
        private System.Windows.Forms.OpenFileDialog ofdiag;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mKey;
        private System.Windows.Forms.ToolStripMenuItem mKeyExport;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.ToolStripMenuItem mViewHelp;
        private System.Windows.Forms.ToolStripMenuItem mAbout;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnFlush;
        private System.Windows.Forms.ToolStripMenuItem mKeySend;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox tbPublicKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrivateKey;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.TextBox tbKeySize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mSettings;
        private System.Windows.Forms.CheckBox chLogs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLogName;
        private System.Windows.Forms.TextBox tbLogPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox boxSettings;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox tbLoad;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.TabControl tabChoice;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.TabPage tabFile;
        private System.Windows.Forms.CheckBox chOptimalPadding;
        private System.Windows.Forms.TextBox tbLoadResult;
        private System.Windows.Forms.GroupBox boxAbout;
        private System.Windows.Forms.TextBox tbAbout;
        private System.Windows.Forms.LinkLabel lbGithub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox boxHelp;
        private System.Windows.Forms.TextBox tbHelp;
        private System.Windows.Forms.Button btnGuideHelp;
        private System.Windows.Forms.Button btnSettingsHelp;

    }
}

