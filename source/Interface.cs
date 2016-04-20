using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;

namespace Rsa_algo
{
    public partial class rsaApp : Form
    {
        private Rsa rsa;
        public rsaApp()
        {
            InitializeComponent();
            rsa = new Rsa();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // key encryption
            string encrypted = rsa.Encrypt(tbKey.Text, tbPublicKey.Text, Convert.ToInt32(tbKeySize.Text));
            if (!String.IsNullOrEmpty(encrypted))
                doWorker(); // do something...
            tbResult.Text = encrypted;
            outError("[" + DateTime.Now + "] RSA encrypted: ", encrypted);
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // key decryption
            string decrypted = rsa.Decrypt(tbKey.Text, tbPrivateKey.Text, Convert.ToInt32(tbKeySize.Text));
            if (!String.IsNullOrEmpty(decrypted))
                doWorker(); // do something...
            tbResult.Text = decrypted;
            outError("[" + DateTime.Now + "] RSA decrypted: ", decrypted);
        }
        private void btnFlush_Click(object sender, EventArgs e)
        {
            // Cleanup boxes with key and result
            tbResult.Text = null;
            tbKey.Text = null;
            btnCopy.Visible = false;
            btnExport.Visible = false;
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            // Select & copy
            tbSelectAndCopy(tbResult);
        }
        private void btnInit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbKeySize.Text))
                return;

            string publicKey, privateKey;
            rsa.GenerateKeys(Convert.ToInt32(tbKeySize.Text), out publicKey, out privateKey);
            doWorker(); // do something...
            tbPublicKey.Text = publicKey;
            tbPrivateKey.Text = privateKey;
            outError("RSA public key: ", publicKey);
            outError("RSA private key: ", privateKey);
        }
        private void outError(string str, object args, bool useMb = false)
        {
            if (useMb)
                MessageBox.Show(str + args);

            if (chLogs.Checked)
            {
                if (String.IsNullOrWhiteSpace(tbLogName.Text))
                    return;

                // create log directory if doesn't exist
                if (!Directory.Exists(tbLogPath.Text))
                    Directory.CreateDirectory(tbLogPath.Text);

                StreamWriter file = new StreamWriter(tbLogPath.Text + tbLogName.Text, false);
                file.WriteLine(str + args);
                file.Close();
                file.Dispose();
            }
        }
        private void mViewHelp_Click(object sender, EventArgs e)
        {
           boxHelp.Visible = !boxHelp.Visible;
        }
        private void mAbout_Click(object sender, EventArgs e)
        {
           boxAbout.Visible = !boxAbout.Visible;
        }
        private void mSettings_Click(object sender, EventArgs e)
        {
           boxSettings.Visible = !boxSettings.Visible;
        }
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (ofdiag.ShowDialog() != DialogResult.OK)
                return;

            string name = ofdiag.FileName;
            if (String.IsNullOrWhiteSpace(name))
                return;

            doWorker(); // do something...

            FileInfo fi = new FileInfo(name);
            long length = fi.Length;
            tbLoad.Text = name;
            tbLoadResult.Text = "File name: " + fi.Name + "\r\n";
            tbLoadResult.Text += "File size: " + length + " bytes\r\n";

            if (fi.Name.Contains(".enc"))
                tbLoadResult.Text += "Attributes: encrypted \r\n";
            else
                tbLoadResult.Text += "Attributes: none";
        }
        private void outFile(string path, string str, object args)
        {
            StreamWriter file = new StreamWriter(path, false);
            file.WriteLine(str + args);
            file.Close();
            file.Dispose();
        }
        private void doWorker()
        {
            pb.Maximum = 100;
            for (int i = 0; i < pb.Maximum; ++i)
                pb.Increment(i);
            pb.Value = 0;
        }
        private void chLogs_CheckedChanged(object sender, EventArgs e)
        {
            tbLogName.ReadOnly = !chLogs.Checked;
            tbLogPath.ReadOnly = !chLogs.Checked;
        }
        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ofdiag.FileName))
                return;

            rsa.fsEncrypt(ofdiag.FileName, tbPublicKey.Text, Convert.ToInt32(tbKeySize.Text));
            doWorker(); // do something...
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ofdiag.FileName))
                return;

            rsa.fsDecrypt(ofdiag.FileName, tbPrivateKey.Text, Convert.ToInt32(tbKeySize.Text));
            doWorker(); // do something...
        }
        private void tbSelectAndCopy(TextBox tb)
        {
            tb.SelectAll();
            tb.Focus();
            tb.Copy();
        }
        private void chOptimalPadding_CheckedChanged(object sender, EventArgs e)
        {
            rsa.setOptimalAsymmetricEncryptionPadding(chLogs.Checked);
        }
        private void lbGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to a URL
            System.Diagnostics.Process.Start("https://github.com/Eliminationzx/RSA-algo");
        }

        private void btnSettingsHelp_Click(object sender, EventArgs e)
        {
            tbHelp.Text = "Settings:\r\n";
            tbHelp.Text += "* Key size - size of key in bytes\r\n";
            tbHelp.Text += "* Use logs - option that enable/disable logs\r\n";
            tbHelp.Text += "* Log path - directory for logs\r\n";
            tbHelp.Text += "* Log name - name of logs\r\n";
            tbHelp.Text += "* Use optimal padding - option that enable/disable optimal padding of file decryption";
        }
        private void btnGuideHelp_Click(object sender, EventArgs e)
        {
            tbHelp.Text = "How to use guide:\r\n";
            tbHelp.Text += "1) Click initialize (firstly check settings!)\r\n";
            tbHelp.Text += "2) Choose type of en/de-cryption (file or text)\r\n";
            tbHelp.Text += "3) Initialize your data (text or file)\r\n";
            tbHelp.Text += "4) Click on button en/de-cryption\r\n";
            tbHelp.Text += "5) Finish";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // show dialog window
            if (savediag.ShowDialog() != DialogResult.OK)
                return;
            // save into the file
            string name = savediag.FileName;
            outFile(name, tbResult.Text, null);
            outFile(name + "_public.xml", tbPublicKey.Text, null);
            outFile(name + "_private.xml", tbPrivateKey.Text, null);
        }
        private void tbResult_TextChanged(object sender, EventArgs e)
        {
            if (!btnCopy.Visible)
                btnCopy.Visible = true;
            if (!btnExport.Visible)
                btnExport.Visible = true;
        }
    }
}
