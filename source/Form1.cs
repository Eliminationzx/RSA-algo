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
using System.Xml;

namespace Rsa_algo
{
    public partial class rsaApp : Form
    {
        public rsaApp()
        {
            InitializeComponent();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // key encryption
            Rsa rsa = new Rsa();
            string encrypted = rsa.Encrypt(tbKey.Text, tbPublicKey.Text, Convert.ToInt32(tbKeySize.Text));
            tbResult.Text = encrypted;
            outError("[" + DateTime.Now + "] RSA encrypted: ", encrypted);
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // key decryption
            Rsa rsa = new Rsa();
            string decrypted = rsa.Decrypt(tbKey.Text, tbPrivateKey.Text, Convert.ToInt32(tbKeySize.Text));
            outError("[" + DateTime.Now + "] RSA decrypted: ", decrypted);
            tbResult.Text = decrypted;
        }
        private void btnFlush_Click(object sender, EventArgs e)
        {
            // Cleanup boxes with key and result
            tbResult.Text = null;
            tbKey.Text = null;
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
            Rsa rsa = new Rsa();
            string publicKey, privateKey;
            rsa.GenerateKeys(Convert.ToInt32(tbKeySize.Text), out publicKey, out privateKey);
            tbPublicKey.Text = publicKey;
            tbPrivateKey.Text = privateKey;
            outError("RSA public key: ", publicKey);
            outError("RSA private key: ", privateKey);
        }
        private void mKeyExport_Click(object sender, EventArgs e)
        {
            // show dialog window
            savediag.ShowDialog();
            // save into the file
            string path = savediag.InitialDirectory + savediag.FileName;
            outFile(path, tbResult.Text, null);
            outFile(path + "_public.xml", tbPublicKey.Text, null);
            outFile(path + "_private.xml", tbPrivateKey.Text, null);
        }
        private void outError(string str, object args, bool useMb = false)
        {
            if (useMb)
                MessageBox.Show(str + args);

            if (chLogs.Checked)
            {
                if (String.IsNullOrWhiteSpace(tbLogPath.Text) ||
                    String.IsNullOrWhiteSpace(tbLogName.Text))
                    return;

                // create log directory if doesn't exist
                if (!Directory.Exists(tbLogPath.Text))
                    Directory.CreateDirectory(tbLogPath.Text);

                StreamWriter file = new StreamWriter(tbLogPath.Text + tbLogName.Text, false);
                file.WriteLine(str + args);
                file.Close();
            }
        }
        private void mViewHelp_Click(object sender, EventArgs e)
        {
            // TODO: write view help algorithm
        }
        private void mAbout_Click(object sender, EventArgs e)
        {
            // TODO: write 'about' algorithm
        }
        private void mKeySend_Click(object sender, EventArgs e)
        {
            // TODO: write send algorithm
        }
        private void mSettings_Click(object sender, EventArgs e)
        {
            boxSettings.Visible = true;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            boxSettings.Visible = false;
        }
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            ofdiag.ShowDialog();
            string path = ofdiag.InitialDirectory + ofdiag.FileName;
            if (!String.IsNullOrWhiteSpace(path))
                tbLoad.Text = path;
        }
        private void outFile(string path, string str, object args)
        {
            StreamWriter file = new StreamWriter(path, false);
            file.WriteLine(str + args);
            file.Close();
        }
        private void doWorker()
        {
            for (int i = 0; i < 100; ++i)
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
            Rsa rsa = new Rsa();
            FileInfo fInfo = new FileInfo(ofdiag.FileName);
            rsa.fsEncrypt(fInfo.FullName, tbPublicKey.Text, Convert.ToInt32(tbKeySize.Text));
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ofdiag.FileName))
                return;
            Rsa rsa = new Rsa();
            FileInfo fInfo = new FileInfo(ofdiag.FileName);
            rsa.fsDecrypt(fInfo.FullName, tbPrivateKey.Text, Convert.ToInt32(tbKeySize.Text));
        }
        private void tbSelectAndCopy(TextBox tb)
        {
            tb.SelectAll();
            tb.Focus();
            tb.Copy();
        }
    }
}
