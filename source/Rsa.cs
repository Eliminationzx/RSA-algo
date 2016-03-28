using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Rsa_algo
{
    class Rsa
    {
        /// <summary>
        /// The padding scheme often used together with RSA encryption.
        /// </summary>
        private bool _optimalAsymmetricEncryptionPadding = false;
        /// <summary>
        // Key generation
        /// </summary>
        public void GenerateKeys(int keySize, out string publicKey, out string publicAndPrivateKey)
        {
            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                publicKey = provider.ToXmlString(false);
                publicAndPrivateKey = provider.ToXmlString(true);
            }
        }
        /// <summary>
        /// Converts the RSA-encrypted text into a string
        /// </summary>
        /// <param name="text">The plain text input</param>
        /// <param name="publicKeyXml">The RSA public key in XML format</param>
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The the RSA-encrypted text</returns>
        public string Encrypt(string text, string publicKeyXml, int keySize)
        {
            var encrypted = EncryptByteArray(Encoding.UTF8.GetBytes(text), publicKeyXml, keySize);
            return Convert.ToBase64String(encrypted);
        }
        /// <summary>
        /// Gets and validates the RSA-encrypted text as a byte array
        /// </summary>
        /// <param name="data">The plain text in byte array format</param>
        /// <param name="publicKeyXml">The RSA public key in XML format</param>
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The the RSA-encrypted byte array</returns>
        private byte[] EncryptByteArray(byte[] data, string publicKeyXml, int keySize)
        {
            if (data == null || data.Length == 0)
            {
                throw new ArgumentException("Data are empty", "data");
            }

            int maxLength = GetMaxDataLength(keySize);

            if (data.Length > maxLength)
            {
                throw new ArgumentException(String.Format("Maximum data length is {0}", maxLength), "data");
            }

            if (!IsKeySizeValid(keySize))
            {
                throw new ArgumentException("Key size is not valid", "keySize");
            }

            if (String.IsNullOrEmpty(publicKeyXml))
            {
                throw new ArgumentException("Key is null or empty", "publicKeyXml");
            }

            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                provider.FromXmlString(publicKeyXml);
                return provider.Encrypt(data, _optimalAsymmetricEncryptionPadding);
            }
        }
        /// <summary>
        /// Converts the RSA-decrypted text into a string
        /// </summary>
        /// <param name="text">The plain text input</param>
        /// <param name="publicKeyXml">The RSA public key in XML format</param>
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The the RSA-decrypted text</returns>
        public string Decrypt(string text, string publicAndPrivateKeyXml, int keySize)
        {
            var decrypted = DecryptByteArray(Convert.FromBase64String(text), publicAndPrivateKeyXml, keySize);
            return Encoding.UTF8.GetString(decrypted);
        }
        /// <summary>
        /// Gets and validates the RSA-decrypted text as a byte array
        /// </summary>
        /// <param name="data">The plain text in byte array format</param>
        /// <param name="publicKeyXml">The RSA public key in XML format</param>
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The the RSA-decrypted byte array</returns>
        private byte[] DecryptByteArray(byte[] data, string publicAndPrivateKeyXml, int keySize)
        {
            if (data == null || data.Length == 0)
            {
                throw new ArgumentException("Data are empty", "data");
            }

            if (!IsKeySizeValid(keySize))
            {
                throw new ArgumentException("Key size is not valid", "keySize");
            }

            if (String.IsNullOrEmpty(publicAndPrivateKeyXml))
            {
                throw new ArgumentException("Key is null or empty", "publicAndPrivateKeyXml");
            }

            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                provider.FromXmlString(publicAndPrivateKeyXml);
                return provider.Decrypt(data, _optimalAsymmetricEncryptionPadding);
            }
        }
        /// <summary>
        /// Gets the maximum data length for a given key
        /// </summary>       
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The maximum allowable data length</returns>
        public int GetMaxDataLength(int keySize)
        {
            if (_optimalAsymmetricEncryptionPadding)
            {
                return ((keySize - 384) / 8) + 7;
            }
            return ((keySize - 384) / 8) + 37;
        }
        /// <summary>
        /// Checks if the given key size if valid
        /// </summary>       
        /// <param name="keySize">The RSA key length</param>
        /// <returns>True if valid; false otherwise</returns>
        public bool IsKeySizeValid(int keySize)
        {
            return keySize >= 384 &&
                   keySize <= 16384 &&
                   keySize % 8 == 0;
        }
    }
}
