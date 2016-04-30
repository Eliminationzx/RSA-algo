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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tbPublicKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrivateKey = new System.Windows.Forms.TextBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.tbLoad = new System.Windows.Forms.TextBox();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.tabChoice = new System.Windows.Forms.TabControl();
            this.tabText = new System.Windows.Forms.TabPage();
            this.tabFile = new System.Windows.Forms.TabPage();
            this.tbLoadResult = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chPadding = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbKeySize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chLogs = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLogName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogPath = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.tabChoice.SuspendLayout();
            this.tabText.SuspendLayout();
            this.tabFile.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(90, 21);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbKey.Size = new System.Drawing.Size(403, 57);
            this.tbKey.TabIndex = 4;
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.Control;
            this.tbResult.Location = new System.Drawing.Point(90, 106);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(403, 40);
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
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(6, 19);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(78, 22);
            this.btnEncrypt.TabIndex = 13;
            this.btnEncrypt.Text = "Encryption";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(6, 56);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(78, 22);
            this.btnDecrypt.TabIndex = 14;
            this.btnDecrypt.Text = "Decryption";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(6, 115);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(78, 21);
            this.btnCopy.TabIndex = 16;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tbPublicKey
            // 
            this.tbPublicKey.Location = new System.Drawing.Point(268, 31);
            this.tbPublicKey.Name = "tbPublicKey";
            this.tbPublicKey.Size = new System.Drawing.Size(247, 20);
            this.tbPublicKey.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(203, 34);
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
            this.label3.Location = new System.Drawing.Point(199, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Private key:";
            // 
            // tbPrivateKey
            // 
            this.tbPrivateKey.Location = new System.Drawing.Point(268, 85);
            this.tbPrivateKey.Name = "tbPrivateKey";
            this.tbPrivateKey.Size = new System.Drawing.Size(247, 20);
            this.tbPrivateKey.TabIndex = 20;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(12, 31);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(163, 43);
            this.btnInit.TabIndex = 21;
            this.btnInit.Text = "Generate";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(6, 21);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(77, 24);
            this.btnLoadFile.TabIndex = 25;
            this.btnLoadFile.Text = "Load";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // tbLoad
            // 
            this.tbLoad.Location = new System.Drawing.Point(89, 24);
            this.tbLoad.Name = "tbLoad";
            this.tbLoad.ReadOnly = true;
            this.tbLoad.Size = new System.Drawing.Size(392, 20);
            this.tbLoad.TabIndex = 26;
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.Location = new System.Drawing.Point(6, 77);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(77, 23);
            this.btnEncryptFile.TabIndex = 27;
            this.btnEncryptFile.Text = "Encryption";
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            this.btnEncryptFile.Click += new System.EventHandler(this.btnEncryptFile_Click);
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Location = new System.Drawing.Point(6, 117);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(77, 22);
            this.btnDecryptFile.TabIndex = 28;
            this.btnDecryptFile.Text = "Decryption";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            // 
            // tabChoice
            // 
            this.tabChoice.Controls.Add(this.tabText);
            this.tabChoice.Controls.Add(this.tabFile);
            this.tabChoice.Controls.Add(this.tabPage1);
            this.tabChoice.Location = new System.Drawing.Point(12, 128);
            this.tabChoice.Name = "tabChoice";
            this.tabChoice.SelectedIndex = 0;
            this.tabChoice.Size = new System.Drawing.Size(507, 181);
            this.tabChoice.TabIndex = 29;
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.btnCopy);
            this.tabText.Controls.Add(this.tbKey);
            this.tabText.Controls.Add(this.btnEncrypt);
            this.tabText.Controls.Add(this.btnDecrypt);
            this.tabText.Controls.Add(this.tbResult);
            this.tabText.Location = new System.Drawing.Point(4, 22);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(3);
            this.tabText.Size = new System.Drawing.Size(499, 155);
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
            this.tabFile.Size = new System.Drawing.Size(499, 155);
            this.tabFile.TabIndex = 1;
            this.tabFile.Text = "File";
            this.tabFile.UseVisualStyleBackColor = true;
            // 
            // tbLoadResult
            // 
            this.tbLoadResult.Location = new System.Drawing.Point(89, 77);
            this.tbLoadResult.Multiline = true;
            this.tbLoadResult.Name = "tbLoadResult";
            this.tbLoadResult.ReadOnly = true;
            this.tbLoadResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLoadResult.Size = new System.Drawing.Size(392, 62);
            this.tbLoadResult.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSaveSettings);
            this.tabPage1.Controls.Add(this.chPadding);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tbKeySize);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.chLogs);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbLogName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbLogPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(499, 155);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chPadding
            // 
            this.chPadding.AutoSize = true;
            this.chPadding.Location = new System.Drawing.Point(371, 70);
            this.chPadding.Name = "chPadding";
            this.chPadding.Size = new System.Drawing.Size(15, 14);
            this.chPadding.TabIndex = 11;
            this.chPadding.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Use optimal padding:";
            // 
            // tbKeySize
            // 
            this.tbKeySize.Location = new System.Drawing.Point(314, 39);
            this.tbKeySize.Name = "tbKeySize";
            this.tbKeySize.Size = new System.Drawing.Size(100, 20);
            this.tbKeySize.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Key size:";
            // 
            // chLogs
            // 
            this.chLogs.AutoSize = true;
            this.chLogs.Location = new System.Drawing.Point(117, 39);
            this.chLogs.Name = "chLogs";
            this.chLogs.Size = new System.Drawing.Size(15, 14);
            this.chLogs.TabIndex = 7;
            this.chLogs.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Use logs:";
            // 
            // tbLogName
            // 
            this.tbLogName.Location = new System.Drawing.Point(117, 102);
            this.tbLogName.Name = "tbLogName";
            this.tbLogName.Size = new System.Drawing.Size(100, 20);
            this.tbLogName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Log name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log path:";
            // 
            // tbLogPath
            // 
            this.tbLogPath.Location = new System.Drawing.Point(117, 64);
            this.tbLogPath.Name = "tbLogPath";
            this.tbLogPath.Size = new System.Drawing.Size(100, 20);
            this.tbLogPath.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 75);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 30);
            this.btnImport.TabIndex = 30;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(93, 75);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(82, 30);
            this.btnExport.TabIndex = 31;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(262, 111);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(152, 23);
            this.btnSaveSettings.TabIndex = 12;
            this.btnSaveSettings.Text = "Save settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // rsaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Rsa_algo.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 322);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.tabChoice);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.tbPrivateKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPublicKey);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rsaApp";
            this.Opacity = 0.92D;
            this.Text = "RSA Algo";
            this.tabChoice.ResumeLayout(false);
            this.tabText.ResumeLayout(false);
            this.tabText.PerformLayout();
            this.tabFile.ResumeLayout(false);
            this.tabFile.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.SaveFileDialog savediag;
        private System.Windows.Forms.OpenFileDialog ofdiag;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox tbPublicKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrivateKey;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox tbLoad;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.TabControl tabChoice;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.TabPage tabFile;
        private System.Windows.Forms.TextBox tbLoadResult;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chPadding;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbKeySize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chLogs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLogName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogPath;
        private System.Windows.Forms.Button btnSaveSettings;

    }
}

