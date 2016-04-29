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

namespace Rsa_algo
{
    public partial class rsaApp : Form
    {
        private Rsa rsa;
        private Logger logger;
        public rsaApp()
        {
            InitializeComponent();
            InitializeOpenFileDiag();
            InitializeSaveFileDiag();
            InitializeSettings();
            InitializeExtentions();
        }
        private void InitializeExtentions()
        {
            string path = tbLogPath.Text;
            string name = tbLogName.Text;
            long logSize = Convert.ToInt64(tbLogSize.Text);
            bool use = chLogs.Checked;
            bool padding = chPadding.Checked;
            int keySize = Convert.ToInt32(tbKeySize.Text);
            rsa = new Rsa(padding, keySize); // Rsa algorithm
            logger = new Logger(use, path, name, logSize);  // Logger
        }
        private void InitializeSettings()
        {
            tbLogPath.Text = RsaAlgoSettings.Default["LogPathConf"].ToString();
            tbLogName.Text = RsaAlgoSettings.Default["LogNameConf"].ToString();
            tbLogSize.Text = RsaAlgoSettings.Default["LogSizeConf"].ToString();
            chLogs.Checked = Convert.ToBoolean(RsaAlgoSettings.Default["UseLogsConf"]);
            chPadding.Checked = Convert.ToBoolean(RsaAlgoSettings.Default["UseOptimalPaddingConf"]);
            tbKeySize.Text = RsaAlgoSettings.Default["KeySizeConf"].ToString();
        }
        private void InitializeOpenFileDiag()
        {
            ofdiag.Filter = "All files (*.rsa)|*.rsa;";
            ofdiag.Title = "Load file browser";
        }
        private void InitializeSaveFileDiag()
        {
            savediag.Title = "Save file browser";
            savediag.Filter = "All files (*.rsa)|*.rsa;";
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbPublicKey.Text))
                return;
            // Key encryption
            string encrypted = rsa.Encrypt(tbKey.Text, tbPublicKey.Text);
            tbResult.Text = encrypted;
            logger.outError("RSA encrypted: ", encrypted);
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbPrivateKey.Text))
                return;
            // Key decryption
            string decrypted = rsa.Decrypt(tbKey.Text, tbPrivateKey.Text);
            tbResult.Text = decrypted;
            logger.outError("RSA decrypted: ", decrypted);
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
            string publicKey, privateKey;
            rsa.GenerateKeys(out publicKey, out privateKey);
            tbPublicKey.Text = publicKey;
            tbPrivateKey.Text = privateKey;
            logger.outError("RSA public key: ", publicKey);
            logger.outError("RSA private key: ", privateKey);
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
        private void outFile(string path, string str, object args)
        {
            StreamWriter file = new StreamWriter(path, false);
            file.WriteLine(str + args);
            file.Close();
            file.Dispose();
        }
        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbPublicKey.Text))
                rsa.fsEncrypt(ofdiag.FileName, tbPublicKey.Text);
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbPrivateKey.Text))
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
                string publicKey = null;
                string privateKey = null;
                string line = null;
                string filename = ofdiag.FileName;
                using (StreamReader sr = new StreamReader(filename))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
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
                // save into the file
                string name = savediag.FileName;
                outFile(name, tbResult.Text + "\n" + rsa.getXmlPublicKey() + "\n" + rsa.getXmlPrivateKey(), null);
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            RsaAlgoSettings.Default["LogPathConf"] = tbLogPath.Text;
            RsaAlgoSettings.Default["LogNameConf"] = tbLogName.Text;
            RsaAlgoSettings.Default["LogSizeConf"] = Convert.ToInt64(tbLogSize.Text);
            RsaAlgoSettings.Default["UseLogsConf"] = chLogs.Checked;
            RsaAlgoSettings.Default["UseOptimalPaddingConf"] = chPadding.Checked;
            RsaAlgoSettings.Default["KeySizeConf"] = Convert.ToInt32(tbKeySize.Text);
            RsaAlgoSettings.Default.Save();
        }
    }
}
