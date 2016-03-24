using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Rsa_algo
{
    class Rsa : ConstantProvider
    {
        public string Encrypt(string data)
        {
            RSAParameters parameters = new RSAParameters();
            RSACryptoServiceProvider provider = new RSACryptoServiceProvider();

            parameters.Exponent = hexToBytes(exp);
            parameters.Modulus = hexToBytes(mod);
            provider.ImportParameters(parameters);

            byte[] bytes = Encoding.UTF8.GetBytes(data);
            byte[] byteData = provider.Encrypt(bytes, false);

            return Convert.ToBase64String(byteData);
        }
        public string Decrypt(string data)
        {
            RSAParameters parameters = new RSAParameters();
            RSACryptoServiceProvider provider = new RSACryptoServiceProvider();

            parameters.Exponent = hexToBytes(exp);
            parameters.Modulus = hexToBytes(mod);
            provider.ImportParameters(parameters);

            byte[] bytes = Convert.FromBase64String(data);
            byte[] byteData = provider.Decrypt(bytes, false);

            return data;
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
