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
            // don't allow encrypt with empty data
            if (isEmpty(tbKey.Text) || isEmpty(tbKeySize.Text) || isEmpty(tbPublicKey.Text))
            {
                outLog("The key could not be encrypted: ", "data is empty, please check necessary fields!", true);
                return;
            }

            // don't use encryption if text box key is base64
            if (IsBase64String(tbKey.Text))
            {
                outLog("The key could not be encrypted: ", "text box with key is base64!", true);
                return;
            }

            doWorker(); // do something...

            // key encryption
            Rsa rsa = new Rsa();
            int key_size = Convert.ToInt32(tbKeySize.Text);
            string encrypted = rsa.Encrypt(tbKey.Text, tbPublicKey.Text, key_size);
            outLog("[" + DateTime.Now + "] RSA encrypted: ", encrypted);
            tbResult.Text = encrypted;
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // don't allow decrypt with empty data
            if (isEmpty(tbKey.Text) || isEmpty(tbKeySize.Text) || isEmpty(tbPrivateKey.Text))
            {
                outLog("The key could not be decrypted: ", "data is empty, please check necessary fields!", true);
                return;
            }

            // don't use decryption if text box key is not base64
            if (!IsBase64String(tbResult.Text))
            {
                outLog("The key could not be decrypted: ", "text box with key is not base64!", true);
                return;
            }

            doWorker(); // do something...

            // key decryption
            Rsa rsa = new Rsa();
            int key_size = Convert.ToInt32(tbKeySize.Text);
            string decrypted = rsa.Decrypt(tbKey.Text, tbPrivateKey.Text, key_size);
            outLog("[" + DateTime.Now + "] RSA decrypted: ", decrypted);
            tbResult.Text = decrypted;
        }
        private bool isEmpty(String str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
        private void btnFlush_Click(object sender, EventArgs e)
        {
            // Cleanup boxes with key and result
            tbResult.Text = null;
            tbKey.Text = null;
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            // Don't allow to copie if the key is empty
            if (isEmpty(tbResult.Text))
            {
                outLog("The key could not be copied : ", "text box with result is empty!", true);
                return;
            }

            // Select & copy
            tbResult.SelectAll();
            tbResult.Focus();
            tbResult.Copy();
            outLog("The key was successfully copied in buffer!", null, true);
        }
        private void btnInit_Click(object sender, EventArgs e)
        {
            // don't allow initialize if key size is indefined
            if (isEmpty(tbKeySize.Text))
            {
                outLog("The key could not be initialized: ", "data is empty, please check necessary fields!", true);
                return;
            }

            doWorker(); // do something...

            Rsa rsa = new Rsa();
            int key_size = Convert.ToInt32(tbKeySize.Text);
            string publicKey, privateKey;
            rsa.GenerateKeys(key_size, out publicKey, out privateKey);
            tbPublicKey.Text = publicKey;
            tbPrivateKey.Text = privateKey;
            outLog("RSA public key: ", publicKey);
            outLog("RSA private key: ", privateKey);
        }
        private void mKeyImport_Click(object sender, EventArgs e)
        {
            // TODO: write key import algorithm
        }
        private void mKeyExport_Click(object sender, EventArgs e)
        {
            // don't save if text box result is empty
            if (isEmpty(tbResult.Text) || isEmpty(tbPublicKey.Text) || isEmpty(tbPrivateKey.Text))
            {
                outLog("The key could not be saved: ", "text box with result is empty!", true);
                return;
            }

            string key = tbResult.Text;
            // show dialog window
            saveKey.ShowDialog();

            // save into the file
            string path = saveKey.InitialDirectory + saveKey.FileName;
            if (!isEmpty(path))
            {
                doWorker(); // do something...
                outFile(path, key, null);
                outFile(path + "public.xml", tbPublicKey.Text, null);
                outFile(path + "private.xml", tbPrivateKey.Text, null);
            }
        }
        private void mFileLoad_Click(object sender, EventArgs e)
        {
           // TODO: write file loading algorithm
        }
        private void outLog(string str, object args, bool useMb = false)
        {
            if (useMb)
                MessageBox.Show(str + args);

            if (chLogs.Checked)
            {              
                if (isEmpty(tbLogPath.Text) || isEmpty(tbLogName.Text))
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
        private void outFile(string path, string str, object args)
        {
            StreamWriter file = new StreamWriter(path, false);
            file.WriteLine(str + args);
            file.Close();
        }
        private bool IsBase64String(string s)
        {
            if (isEmpty(s))
                return false;
            s = s.Trim();
            return (s.Length % 4 == 0) && Regex.IsMatch(s, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
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
    }
}
