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
            this.saveKey = new System.Windows.Forms.SaveFileDialog();
            this.ofdiag = new System.Windows.Forms.OpenFileDialog();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mfileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mKeyImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mKeyExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mKeySend = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mAbout = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(73, 211);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbKey.Size = new System.Drawing.Size(437, 53);
            this.tbKey.TabIndex = 4;
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.Control;
            this.tbResult.Location = new System.Drawing.Point(73, 369);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(437, 60);
            this.tbResult.TabIndex = 5;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // saveKey
            // 
            this.saveKey.FileName = "Key.rsa";
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
            this.pb.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.keyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mfileLoad});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mfileLoad
            // 
            this.mfileLoad.Name = "mfileLoad";
            this.mfileLoad.Size = new System.Drawing.Size(100, 22);
            this.mfileLoad.Text = "Load";
            this.mfileLoad.Click += new System.EventHandler(this.mFileLoad_Click);
            // 
            // keyToolStripMenuItem
            // 
            this.keyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mKeyImport,
            this.mKeyExport,
            this.mKeySend});
            this.keyToolStripMenuItem.Name = "keyToolStripMenuItem";
            this.keyToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.keyToolStripMenuItem.Text = "Key";
            // 
            // mKeyImport
            // 
            this.mKeyImport.Name = "mKeyImport";
            this.mKeyImport.Size = new System.Drawing.Size(152, 22);
            this.mKeyImport.Text = "Import";
            this.mKeyImport.Click += new System.EventHandler(this.mKeyImport_Click);
            // 
            // mKeyExport
            // 
            this.mKeyExport.Name = "mKeyExport";
            this.mKeyExport.Size = new System.Drawing.Size(152, 22);
            this.mKeyExport.Text = "Export";
            this.mKeyExport.Click += new System.EventHandler(this.mKeyExport_Click);
            // 
            // mKeySend
            // 
            this.mKeySend.Name = "mKeySend";
            this.mKeySend.Size = new System.Drawing.Size(152, 22);
            this.mKeySend.Text = "Send";
            this.mKeySend.Click += new System.EventHandler(this.mKeySend_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mViewHelp,
            this.mAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
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
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(156, 295);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(103, 38);
            this.btnEncrypt.TabIndex = 13;
            this.btnEncrypt.Text = "Encryption";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(295, 295);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(103, 38);
            this.btnDecrypt.TabIndex = 14;
            this.btnDecrypt.Text = "Decryption";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnFlush
            // 
            this.btnFlush.Location = new System.Drawing.Point(26, 209);
            this.btnFlush.Name = "btnFlush";
            this.btnFlush.Size = new System.Drawing.Size(41, 23);
            this.btnFlush.TabIndex = 15;
            this.btnFlush.Text = "Flush";
            this.btnFlush.UseVisualStyleBackColor = true;
            this.btnFlush.Click += new System.EventHandler(this.btnFlush_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(26, 369);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(41, 23);
            this.btnCopy.TabIndex = 16;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tbPublicKey
            // 
            this.tbPublicKey.Location = new System.Drawing.Point(295, 90);
            this.tbPublicKey.Name = "tbPublicKey";
            this.tbPublicKey.Size = new System.Drawing.Size(215, 20);
            this.tbPublicKey.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(230, 93);
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
            this.label3.Location = new System.Drawing.Point(226, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Private key:";
            // 
            // tbPrivateKey
            // 
            this.tbPrivateKey.Location = new System.Drawing.Point(295, 144);
            this.tbPrivateKey.Name = "tbPrivateKey";
            this.tbPrivateKey.Size = new System.Drawing.Size(215, 20);
            this.tbPrivateKey.TabIndex = 20;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(55, 117);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(125, 43);
            this.btnInit.TabIndex = 21;
            this.btnInit.Text = "Initialize";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // tbKeySize
            // 
            this.tbKeySize.Location = new System.Drawing.Point(107, 91);
            this.tbKeySize.Name = "tbKeySize";
            this.tbKeySize.Size = new System.Drawing.Size(73, 20);
            this.tbKeySize.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Key size:";
            // 
            // rsaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Rsa_algo.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKeySize);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.tbPrivateKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPublicKey);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnFlush);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbKey);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.SaveFileDialog saveKey;
        private System.Windows.Forms.OpenFileDialog ofdiag;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mfileLoad;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mKeyExport;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem mKeyImport;

    }
}

