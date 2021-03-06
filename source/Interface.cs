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
using System.Xml;

namespace Rsa_algo
{
    public partial class rsaApp : Form
    {
        private Rsa rsa;
        public rsaApp()
        {
            InitializeComponent();
            InitializeSettings();
            InitializeExtentions();
        }
        private void InitializeExtentions()
        {
            // Settings
            string logPath = tbLogPath.Text;
            string logName = tbLogName.Text;
            bool useLogs = chLogs.Checked;
            bool padding = chPadding.Checked;
            int keySize = Convert.ToInt32(tbKeySize.Text);
            rsa = new Rsa(padding, keySize, useLogs, logPath, logName); // RSA algorithm
        }
        private void InitializeSettings()
        {
            tbLogPath.Text = RsaAlgoSettings.Default["LogPathConf"].ToString(); // Log path setting
            tbLogName.Text = RsaAlgoSettings.Default["LogNameConf"].ToString(); // Log name setting
            chLogs.Checked = Convert.ToBoolean(RsaAlgoSettings.Default["UseLogsConf"]); // Use logs settings
            chPadding.Checked = Convert.ToBoolean(RsaAlgoSettings.Default["UseOptimalPaddingConf"]); // Use optimal padding settings
            tbKeySize.Text = RsaAlgoSettings.Default["KeySizeConf"].ToString(); // Rsa key size setting
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbPublicKey.Text) ||
                String.IsNullOrWhiteSpace(tbKey.Text))
                return;

            // Run timer
            timer1.Start();

            // Key encryption
            string encrypted = rsa.Encrypt(tbKey.Text, tbPublicKey.Text);
            tbResult.Text = encrypted;
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbPrivateKey.Text) ||
                String.IsNullOrWhiteSpace(tbKey.Text))
                return;

            // Run timer
            timer1.Start();

            // Key decryption
            string decrypted = rsa.Decrypt(tbKey.Text, tbPrivateKey.Text);
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
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Run timer
            timer1.Start();

            string publicKey, privateKey;
            rsa.GenerateKeys(out publicKey, out privateKey);
            tbPublicKey.Text = publicKey;
            tbPrivateKey.Text = privateKey;
        }
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (ofdiag.ShowDialog() == DialogResult.OK)
            {
                string name = ofdiag.FileName;
                if (String.IsNullOrWhiteSpace(name))
                    return;

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
        }
        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
           // Run timer
           timer1.Start();

           rsa.fsEncrypt(ofdiag.FileName, tbPublicKey.Text);
        }
        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
           // Run timer
           timer1.Start();

           rsa.fsDecrypt(ofdiag.FileName, tbPrivateKey.Text);
        }
        private void tbSelectAndCopy(TextBox tb)
        {
            tb.SelectAll();
            tb.Focus();
            tb.Copy();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (ofdiag.ShowDialog() == DialogResult.OK)
            {
                // RSA key import
                string publicKey = null;
                string privateKey = null;
                string line = null;
                using (StreamReader sr = new StreamReader(ofdiag.FileName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Find RSA key value tag
                        if (line.Contains("<RSAKeyValue>"))
                        {
                            // Find private key
                            if (line.Contains("<P>"))
                                privateKey = line;
                            else
                                publicKey = line;
                        }
                    }
                }
                rsa.setXmlKeys(publicKey, privateKey);
                tbPublicKey.Text = publicKey;
                tbPrivateKey.Text = privateKey;
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (savediag.ShowDialog() == DialogResult.OK)
            {
                // RSA Keys export
                string path = savediag.FileName;
                StreamWriter file = new StreamWriter(path, false);
                file.WriteLine(tbResult.Text + "\n" + rsa.getXmlPublicKey() + "\n" + rsa.getXmlPrivateKey());
                file.Close();
                file.Dispose();
            }
        }
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            // Save user settings
            RsaAlgoSettings.Default["LogPathConf"] = tbLogPath.Text;
            RsaAlgoSettings.Default["LogNameConf"] = tbLogName.Text;
            RsaAlgoSettings.Default["UseLogsConf"] = chLogs.Checked;
            RsaAlgoSettings.Default["UseOptimalPaddingConf"] = chPadding.Checked;
            RsaAlgoSettings.Default["KeySizeConf"] = Convert.ToInt32(tbKeySize.Text);
            RsaAlgoSettings.Default.Save();
            Application.Restart();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbProcessing.PerformStep();

            // Stop timer and refresh value of the progress bar
            if (pbProcessing.Value == pbProcessing.Maximum)
            {
                timer1.Stop();
                pbProcessing.Value = pbProcessing.Minimum;
            }
        }
    }
}
