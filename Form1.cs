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

namespace Rsa_algo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e)
        {
            // Just exit
            Application.Exit();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // don't use encryption if text box key is empty or is base64
            if (isEmpty(tbkey.Text) || IsBase64String(tbkey.Text))
            {
                outLog("Can't encrypt key: ", "The text box with key is empty or is base64!", true);
                return;
            }
            // key encryption
            Rsa rsa = new Rsa();
            string key = setKey(Convert.ToString(tbkey), rsa);
            outLog("[" + DateTime.Now + "] RSA Public Key: ", key);
            tbResult.Text = key;
        }
        private void tbResult_TextChanged(object sender, EventArgs e) { }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // don't use decryption if text box key is empty or is not base64
            if (isEmpty(tbkey.Text) || !IsBase64String(tbResult.Text))
            {
                outLog("Can't decrypt key: ", "The text box with key is empty or not base64!", true);
                return;
            }
            // key decryption
            Rsa rsa = new Rsa();
            string key = getKey(Convert.ToString(tbkey), rsa);
            outLog("RSA decrypt result: ", key);
            tbResult.Text = key;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // don't save if text box result is empty
            if (isEmpty(tbResult.Text))
            {
                outLog("Can't save key: ", "The text box with result is empty!", true);
                return;
            }
            string key = tbResult.Text;
            // show dialog window
            saveKey.ShowDialog();
            // save into the file
            string path = saveKey.InitialDirectory + saveKey.FileName;
            outFile(path, key, null);
        }
        private bool isEmpty(String str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ofdiag.ShowDialog();
            string path = ofdiag.InitialDirectory + ofdiag.FileName;
            if (!path.Contains(".rsa")) // file type is .rsa
            {
                outLog("The file could not be read : ", "wrong file type!", true);
                return;
            }
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(path))
                {
                    // Read the stream to a string, and write the string to the console.
                    String tmp = sr.ReadToEnd();
                    if (IsBase64String(tmp))
                        tbkey.Text = tmp;
                }
            }
            catch (Exception exc)
            {
                outLog("The file could not be read: ", exc.Message);
            }
        }
        private void outLog(string str, object args, bool useMb = false)
        {
            string path = "logs/RSALogger.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(str + args);
            if (useMb)
                MessageBox.Show(str + args);
            file.Close();
        }
        private void outFile(string path, string str, object args)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(str + args);
            file.Close();
        }
        private string getKey(string str, Rsa rsa)
        {
            string key = null;
            try
            {
                key = rsa.Decrypt(str);
            }
            catch (Exception e)
            {
                outLog("The key can't be decrypted: ", e.Message);
            }
            return key;
        }
        private string setKey(string str, Rsa rsa)
        {
            string key = null;
            try
            {
                key = rsa.Encrypt(str);
            }
            catch (Exception e)
            {
                outLog("The key can't be encrypted: ", e.Message);
            }
            return key;
        }
        private bool IsBase64String(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;
            s = s.Trim();
            return (s.Length % 4 == 0) && Regex.IsMatch(s, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
        }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}
