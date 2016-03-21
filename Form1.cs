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

namespace Rsa_algo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Just exit
            Application.Exit();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Rsa rsa = new Rsa();
            // don't use encryption if text box key is empty
            if (isEmpty(tbkey.Text))
            {
                outLog(rsa.logPath, "Can't encrypt key: ", "The text box with key is empty!", true);
                return;
            }

            // key encryption
            string key = setKey(Convert.ToString(tbkey), rsa);
            outLog(rsa.logPath, "[" + DateTime.Now + "] RSA Public Key: ", key);
            tbResult.Text = key;
        }
        private void tbResult_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Rsa rsa = new Rsa();
            // don't use decryption if text box key is empty
            if (isEmpty(tbkey.Text))
            {
                outLog(rsa.logPath, "Can't decrypt key: ", "The text box with key is empty!", true);
                return;
            }

            // key decryption
            string key = getKey(Convert.ToString(tbkey), rsa);
            outLog(rsa.logPath, "RSA decrypt result: ", key);
            tbResult.Text = key;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Rsa rsa = new Rsa();
            // don't save if text box result is empty
            if (isEmpty(tbResult.Text))
            {
                outLog(rsa.logPath, "Can't save key: ", "The text box with result is empty!", true);
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
            Rsa rsa = new Rsa();
            string path = ofdiag.InitialDirectory + ofdiag.FileName;
            if (!path.Contains(rsa.fileType))
            {
                outLog(rsa.logPath, "The file could not be read : ", "wrong file type!", true);
                return;
            }
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(path))
                {
                    // Read the stream to a string, and write the string to the console.
                    String tmp = sr.ReadToEnd();
                    if (rsa.IsBase64String(tmp))
                        tbkey.Text = tmp;
                }
            }
            catch (Exception exc)
            {
                outLog(rsa.logPath, "The file could not be read: ", exc.Message);
            }
        }
        private void outLog(string path, string str, object args, bool useMb = false)
        {
            TextWriterTraceListener twtl = new TextWriterTraceListener(path, AppDomain.CurrentDomain.FriendlyName);
            twtl.Name = "RSALogger";
            twtl.TraceOutputOptions = TraceOptions.ThreadId | TraceOptions.DateTime;
            Trace.Listeners.Add(twtl);
            Trace.AutoFlush = true;
            Trace.WriteLine(str + args);
            if (useMb)
                MessageBox.Show(str + args);
        }
        private void outFile(string path, string str, object args)
        {
            TextWriterTraceListener twtl = new TextWriterTraceListener(path, AppDomain.CurrentDomain.FriendlyName);
            twtl.Name = "RSASaver";
            twtl.TraceOutputOptions = TraceOptions.ThreadId | TraceOptions.DateTime;
            Trace.Listeners.Add(twtl);
            Trace.AutoFlush = true;
            Trace.WriteLine(str + args);
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
                outLog(rsa.logPath, "The key can't be decrypted: ", e.Message);
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
                outLog(rsa.logPath, "The key can't be encrypted: ", e.Message);
            }
            return key;
        }
    }
}
