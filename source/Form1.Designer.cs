namespace Rsa_algo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbkey = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.saveKey = new System.Windows.Forms.SaveFileDialog();
            this.btnload = new System.Windows.Forms.Button();
            this.ofdiag = new System.Windows.Forms.OpenFileDialog();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(337, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 42);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(337, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 42);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(337, 135);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(84, 42);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decryption";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(337, 72);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(84, 42);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encryption";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbkey
            // 
            this.tbkey.Location = new System.Drawing.Point(12, 62);
            this.tbkey.Multiline = true;
            this.tbkey.Name = "tbkey";
            this.tbkey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbkey.Size = new System.Drawing.Size(303, 91);
            this.tbkey.TabIndex = 4;
            this.tbkey.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.Control;
            this.tbResult.Location = new System.Drawing.Point(12, 181);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(303, 103);
            this.tbResult.TabIndex = 5;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // saveKey
            // 
            this.saveKey.FileName = "Key.rsa";
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(337, 12);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(84, 42);
            this.btnload.TabIndex = 6;
            this.btnload.Text = "Load key";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofdiag
            // 
            this.ofdiag.FileName = "key.rsa";
            this.ofdiag.Tag = "";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(12, 21);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(303, 22);
            this.pb.TabIndex = 7;
            this.pb.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Rsa_algo.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(433, 307);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbkey);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.92D;
            this.Text = "RSA Algo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbkey;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.SaveFileDialog saveKey;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.OpenFileDialog ofdiag;
        private System.Windows.Forms.ProgressBar pb;

    }
}

