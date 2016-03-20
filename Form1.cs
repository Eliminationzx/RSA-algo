using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // key encryption
            Rsa rsa = new Rsa();
            string key = rsa.setKey(Convert.ToString(tbkey));
            rsa.outLog("[" + DateTime.Now + "] RSA Public Key: ", key);
            tbResult.Text = key;
        }
        private void tbResult_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // key decryption
            Rsa rsa = new Rsa();
            string key = rsa.getKey(Convert.ToString(tbkey));
            rsa.outLog("RSA decrypt result: ", key);
            tbResult.Text = key;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string key = tbResult.Text;
            // show dialog window
            saveKey.ShowDialog();

            // save into the file
            Rsa rsa = new Rsa();
            string path = saveKey.InitialDirectory + saveKey.FileName;
            
            rsa.outFile(path, "RSA Public key: ", key);
        }
    }
}
