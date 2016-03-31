﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Rsa_algo
{
    class Rsa
    {
        /// <summary>
        /// The padding scheme often used together with RSA encryption.
        /// </summary>
        private bool _optimalAsymmetricEncryptionPadding;
        public void setOptimalAsymmetricEncryptionPadding(bool padding)
        {
            _optimalAsymmetricEncryptionPadding = padding;
        }
        /// <summary>
        // Key generation
        /// </summary>
        public void GenerateKeys(int keySize, out string publicKey, out string privateKey)
        {
            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                publicKey = provider.ToXmlString(false);
                privateKey = provider.ToXmlString(true);
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
            int maxLength = GetMaxDataLength(keySize);
            if (data.Length > maxLength)
            {
                throw new ArgumentException(String.Format("Maximum data length is {0}", maxLength), "data");
            }

            if (!IsKeySizeValid(keySize))
            {
                throw new ArgumentException("Key size is not valid", "keySize");
            }

            try
            {
                using (var provider = new RSACryptoServiceProvider(keySize))
                {
                    provider.FromXmlString(publicKeyXml);
                    return provider.Encrypt(data, _optimalAsymmetricEncryptionPadding);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
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
            if (!IsKeySizeValid(keySize))
            {
                throw new ArgumentException("Key size is not valid", "keySize");
            }

            try
            {
                using (var provider = new RSACryptoServiceProvider(keySize))
                {
                    provider.FromXmlString(publicAndPrivateKeyXml);
                    return provider.Decrypt(data, _optimalAsymmetricEncryptionPadding);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
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
        /// <summary>
        // File encryption algorithm
        /// </summary>
        ///
        public void fsEncrypt(string inFile, string publicAndPrivateKeyXml, int keySize)
        {
            EncryptFile(inFile, publicAndPrivateKeyXml, keySize);
        }
        private void EncryptFile(string inFile, string publicAndPrivateKeyXml, int keySize)
        {
            // Create instance of Rijndael for
            // symetric encryption of the data
            RijndaelManaged rjndl = new RijndaelManaged();
            rjndl.KeySize = 256;
            rjndl.BlockSize = 256;
            rjndl.Mode = CipherMode.CBC;
            ICryptoTransform transform = rjndl.CreateEncryptor();

            // Use RSACryptoServiceProvider to
            // enrypt the Rijndael key
            // rsa is previously instantiated: 
            //    rsa = new RSACryptoServiceProvider(cspp);
            byte[] keyEncrypted = EncryptByteArray(rjndl.Key, publicAndPrivateKeyXml, keySize);

            // Create byte arrays to contain
            // the length values of the key and IV
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            int lKey = keyEncrypted.Length;
            LenK = BitConverter.GetBytes(lKey);
            int lIV = rjndl.IV.Length;
            LenIV = BitConverter.GetBytes(lIV);

            // Write the following to the FileStream
            // for the encrypted file (outFs):
            // - length of the key
            // - length of the IV
            // - ecrypted key
            // - the IV
            // - the encrypted cipher content

            int startFileName = inFile.LastIndexOf("\\") + 1;

            // Change the file's extension to ".enc"
            string outFile = inFile.Substring(startFileName, inFile.LastIndexOf(".") - startFileName) + ".enc";

            try
            {
                using (FileStream outFs = new FileStream(outFile, FileMode.CreateNew))
                {
                    outFs.Write(LenK, 0, 4);
                    outFs.Write(LenIV, 0, 4);
                    outFs.Write(keyEncrypted, 0, lKey);
                    outFs.Write(rjndl.IV, 0, lIV);

                    // Now write the cipher text using
                    // a CryptoStream for encrypting
                    using (CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {

                        // By encrypting a chunk at
                        // a time, you can save memory
                        // and accommodate large files
                        int count = 0;
                        int offset = 0;

                        // blockSizeBytes can be any arbitrary size
                        int blockSizeBytes = rjndl.BlockSize / 8;
                        byte[] data = new byte[blockSizeBytes];
                        int bytesRead = 0;

                        using (FileStream inFs = new FileStream(inFile, FileMode.Open))
                        {
                            do
                            {
                                count = inFs.Read(data, 0, blockSizeBytes);
                                offset += count;
                                outStreamEncrypted.Write(data, 0, count);
                                bytesRead += blockSizeBytes;
                            }
                            while (count > 0);
                            inFs.Close();
                        }
                        outStreamEncrypted.FlushFinalBlock();
                        outStreamEncrypted.Close();
                    }
                    outFs.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        // File decryption algorithm
        /// </summary>
        public void fsDecrypt(string inFile, string publicAndPrivateKeyXml, int keySize)
        {
            DecryptFile(inFile, publicAndPrivateKeyXml, keySize);
        }
        private void DecryptFile(string inFile, string publicAndPrivateKeyXml, int keySize)
        {
            // Create instance of Rijndael for
            // symetric decryption of the data
            RijndaelManaged rjndl = new RijndaelManaged();
            rjndl.KeySize = 256;
            rjndl.BlockSize = 256;
            rjndl.Mode = CipherMode.CBC;

            // Create byte arrays to get the length of
            // the encrypted key and IV
            // These values were stored as 4 bytes each
            // at the beginning of the encrypted package
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            // Consruct the file name for the decrypted file
            string outFile = inFile.Substring(0, inFile.LastIndexOf(".")) + ".dec";

            try
            {
                // Use FileStream objects to read the encrypted
                // file (inFs) and save the decrypted file (outFs)
                using (FileStream inFs = new FileStream(inFile, FileMode.Open))
                {

                    inFs.Seek(0, SeekOrigin.Begin);
                    inFs.Seek(0, SeekOrigin.Begin);
                    inFs.Read(LenK, 0, 3);
                    inFs.Seek(4, SeekOrigin.Begin);
                    inFs.Read(LenIV, 0, 3);

                    // Convert the lengths to integer values
                    int lenK = BitConverter.ToInt32(LenK, 0);
                    int lenIV = BitConverter.ToInt32(LenIV, 0);

                    // Determine the start postition of
                    // the ciphter text (startC)
                    // and its length(lenC)
                    int startC = lenK + lenIV + 8;
                    int lenC = (int)inFs.Length - startC;

                    // Create the byte arrays for
                    // the encrypted Rijndael key
                    // the IV, and the cipher text
                    byte[] KeyEncrypted = new byte[lenK];
                    byte[] IV = new byte[lenIV];

                    // Extract the key and IV
                    // starting from index 8
                    // after the length values
                    inFs.Seek(8, SeekOrigin.Begin);
                    inFs.Read(KeyEncrypted, 0, lenK);
                    inFs.Seek(8 + lenK, SeekOrigin.Begin);
                    inFs.Read(IV, 0, lenIV);
                    // Use RSACryptoServiceProvider
                    // to decrypt the Rijndael key
                    byte[] KeyDecrypted = DecryptByteArray(KeyEncrypted, publicAndPrivateKeyXml, keySize);

                    // Decrypt the key
                    ICryptoTransform transform = rjndl.CreateDecryptor(KeyDecrypted, IV);

                    // Decrypt the cipher text from
                    // from the FileSteam of the encrypted
                    // file (inFs) into the FileStream
                    // for the decrypted file (outFs)
                    using (FileStream outFs = new FileStream(outFile, FileMode.CreateNew))
                    {
                        int count = 0;
                        int offset = 0;

                        // blockSizeBytes can be any arbitrary size
                        int blockSizeBytes = rjndl.BlockSize / 8;
                        byte[] data = new byte[blockSizeBytes];


                        // By decrypting a chunk a time
                        // you can save memory and
                        // accommodate large files

                        // Start at the beginning
                        // of the cipher text
                        inFs.Seek(startC, SeekOrigin.Begin);
                        using (CryptoStream outStreamDecrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                        {
                            do
                            {
                                count = inFs.Read(data, 0, blockSizeBytes);
                                offset += count;
                                outStreamDecrypted.Write(data, 0, count);

                            }
                            while (count > 0);

                            outStreamDecrypted.FlushFinalBlock();
                            outStreamDecrypted.Close();
                        }
                        outFs.Close();
                    }
                    inFs.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
