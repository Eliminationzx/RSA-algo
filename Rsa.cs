using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Rsa_algo
{
    class Rsa
    {
        public string Exponent
        {
            set
            {
                _exponent = hexToBytes(value);
            }
        }
        public string Modulus
        {
            set
            {
                _modulus = hexToBytes(value);
            }
        }
        public string Encrypt(string data)
        {
            if (data == null) throw new ArgumentNullException("data");
            try
            {
                    byte[] byteData = Encoding.ASCII.GetBytes(data);
                    var parameters = new RSAParameters();
                    var provider = new RSACryptoServiceProvider();

                    parameters.Exponent = _exponent;
                    parameters.Modulus = _modulus;

                    provider.ImportParameters(parameters);
                    return Convert.ToBase64String(provider.Encrypt(byteData, false)).ToString();
            }
            catch 
            { 
                return null; 
            }
        }
        public string Decrypt(string data, bool foo)
        {
            return null;
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
        private byte[] _exponent;
        private byte[] _modulus;
    }
}
