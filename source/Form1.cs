﻿using System;
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
                outError("The key could not be encrypted: ", "data is empty, please check necessary fields!", true);
                return;
            }

            // don't use encryption if text box key is base64
            if (IsBase64String(tbKey.Text))
            {
                outError("The key could not be encrypted: ", "text box with key is base64!", true);
                return;
            }

            doWorker(); // do something...

            // key encryption
            Rsa rsa = new Rsa();
            int key_size = Convert.ToInt32(tbKeySize.Text);
            string encrypted = rsa.Encrypt(tbKey.Text, tbPublicKey.Text, key_size);
            outError("[" + DateTime.Now + "] RSA encrypted: ", encrypted);
            tbResult.Text = encrypted;
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // don't allow decrypt with empty data
            if (isEmpty(tbKey.Text) || isEmpty(tbKeySize.Text) || isEmpty(tbPrivateKey.Text))
            {
                outError("The key could not be decrypted: ", "data is empty, please check necessary fields!", true);
                return;
            }

            // don't use decryption if text box key is not base64
            if (!IsBase64String(tbResult.Text))
            {
                outError("The key could not be decrypted: ", "text box with key is not base64!", true);
                return;
            }

            doWorker(); // do something...

            // key decryption
            Rsa rsa = new Rsa();
            int key_size = Convert.ToInt32(tbKeySize.Text);
            string decrypted = rsa.Decrypt(tbKey.Text, tbPrivateKey.Text, key_size);
            outError("[" + DateTime.Now + "] RSA decrypted: ", decrypted);
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
                outError("The key could not be copied : ", "text box with result is empty!", true);
                return;
            }

            // Select & copy
            tbResult.SelectAll();
            tbResult.Focus();
            tbResult.Copy();
            outError("The key was successfully copied in buffer!", null, true);
        }
        private void btnInit_Click(object sender, EventArgs e)
        {
            // don't allow initialize if key size is indefined
            if (isEmpty(tbKeySize.Text))
            {
                outError("The key could not be initialized: ", "data is empty, please check necessary fields!", true);
                return;
            }

            doWorker(); // do something...

            Rsa rsa = new Rsa();
            int key_size = Convert.ToInt32(tbKeySize.Text);
            string publicKey, privateKey;
            rsa.GenerateKeys(key_size, out publicKey, out privateKey);
            tbPublicKey.Text = publicKey;
            tbPrivateKey.Text = privateKey;
            outError("RSA public key: ", publicKey);
            outError("RSA private key: ", privateKey);
        }
        private void mKeyExport_Click(object sender, EventArgs e)
        {
            // don't save if text box result is empty
            if (isEmpty(tbResult.Text) || isEmpty(tbPublicKey.Text) || isEmpty(tbPrivateKey.Text) || isEmpty(savediag.FileName))
            {
                outError("The key could not be saved: ", "text box with result is empty!", true);
                return;
            }

            string key = tbResult.Text;
            // show dialog window
            savediag.ShowDialog();

            // save into the file
            string path = savediag.InitialDirectory + savediag.FileName;
            doWorker(); // do something...
            outFile(path, key, null);
            outFile(path + "public.xml", tbPublicKey.Text, null);
            outFile(path + "private.xml", tbPrivateKey.Text, null);
        }
        private void outError(string str, object args, bool useMb = false)
        {
            if (useMb)
                MessageBox.Show(str + args);

            if (chLogs.Checked)
            {              
                if (isEmpty(tbLogPath.Text) || isEmpty(tbLogName.Text))
                    return;

                if (!IsPath(tbLogPath.Text))
                {
                    outError("Logs could not be written: ", "wrong logs folder!", true);
                    return;
                }

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
            if (!isEmpty(path))
                tbLoad.Text = path;
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
        private bool IsPath(string s)
        {
            if (isEmpty(s))
                return false;
            return s.Contains(":") || s.Contains("\\");
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
            if (isEmpty(tbPublicKey.Text) || isEmpty(ofdiag.FileName))
            {
                outError("The file could not be encrypted: ", "data is empty, please check necessary fields!", true);
                return;
            }

            Rsa rsa = new Rsa();
            FileInfo fInfo = new FileInfo(ofdiag.FileName);
            // Pass the file name without the path.
            string name = fInfo.FullName;
            doWorker(); // do something...
            rsa.EncryptFile(name, tbPublicKey.Text, Convert.ToInt32(tbKeySize.Text));
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            if (isEmpty(tbPrivateKey.Text) || isEmpty(ofdiag.FileName))
            {
                outError("The file could not be encrypted: ", "data is empty, please check necessary fields!", true);
                return;
            }

            Rsa rsa = new Rsa();
            FileInfo fInfo = new FileInfo(ofdiag.FileName);
            // Pass the file name without the path.
            string name = fInfo.FullName;
            doWorker(); // do something...
            rsa.DecryptFile(name, tbPrivateKey.Text, Convert.ToInt32(tbKeySize.Text));
        }
    }
}
