using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Diagnostics;

namespace Rsa_algo
{
    class Rsa : ConstantProvider
    {
        public string Encrypt(string data)
        {
            byte[] byteData;
            RSAParameters parameters = new RSAParameters();
            RSACryptoServiceProvider provider = new RSACryptoServiceProvider();

            parameters.Exponent = hexToBytes(exp);
            parameters.Modulus = hexToBytes(mod);
            provider.ImportParameters(parameters);

            byteData = provider.Encrypt(Encoding.UTF8.GetBytes(data), false);

            return Convert.ToBase64String(byteData);
        }
        public string Decrypt(string data)
        {
            byte[] byteData;
            RSAParameters parameters = new RSAParameters();
            RSACryptoServiceProvider provider = new RSACryptoServiceProvider();

            parameters.Exponent = hexToBytes(exp);
            parameters.Modulus = hexToBytes(mod);
            provider.ImportParameters(parameters);

            byteData = provider.Decrypt(Convert.FromBase64String(data), true);

            return Encoding.UTF8.GetString(byteData);
        }
        public void outLog(string str, object args)
        {
            TextWriterTraceListener twtl = new TextWriterTraceListener(logPath, AppDomain.CurrentDomain.FriendlyName);
            twtl.Name = "RSALogger";
            twtl.TraceOutputOptions = TraceOptions.ThreadId | TraceOptions.DateTime;
            Trace.Listeners.Add(twtl);
            Trace.AutoFlush = true;
            Trace.WriteLine(str + args);
        }
        public void outFile(string path, string str, object args)
        {
            TextWriterTraceListener twtl = new TextWriterTraceListener(path, AppDomain.CurrentDomain.FriendlyName);
            twtl.Name = "RSASaver";
            twtl.TraceOutputOptions = TraceOptions.ThreadId | TraceOptions.DateTime;
            Trace.Listeners.Add(twtl);
            Trace.AutoFlush = true;
            Trace.WriteLine(str + args);
        }
        public string getKey(string str)
        {
            string key;
            try
            {
                key = Decrypt(str);
            }
            catch
            {
                key = str;
            }
            return key;
        }
        public string setKey(string str)
        {
            string key;
            try
            {
                key = Encrypt(str);
            }
            catch
            {
                key = str;
            }
            return key;
        }
        private byte[] hexToBytes(string hex)
        {
            byte[] arr = new byte[hex.Length >> 1];
            for (int i = 0; i < hex.Length >> 1; i++)
            {
                arr[i] = (byte)((getHexVal(hex[i << 1]) << 4) + (getHexVal(hex[(i << 1) + 1])));
            }
            return arr;
        }
        private int getHexVal(char hex)
        {
            int val = (int)hex;
            return val - (val < 58 ? 48 : 55);
        }
    }
}
