using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

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
        public bool IsBase64String(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;

            s = s.Trim();
            return (s.Length % 4 == 0) && Regex.IsMatch(s, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
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
