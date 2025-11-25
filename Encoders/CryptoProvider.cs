using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Encoders
{
    internal class CryptoProvider
    {

        protected static DES des = DES.Create();
        ~CryptoProvider() { 
            des.Dispose();
        }
        public static string GenerateKey()
        {
            des.GenerateKey();
            return Convert.ToBase64String(des.Key).Substring(0, 8);   
        }

        public static string GenerateIV()
        {
            des.GenerateIV();
            return Convert.ToBase64String(des.IV).Substring(0, 8);
        }

        public static CipherMode GetCipherModeFromString(string mode)
        {
            return mode.ToUpper() switch
            {
                "CBC" => CipherMode.CBC,
                "ECB" => CipherMode.ECB,
                "CFB" => CipherMode.CFB,
                "OFB" => CipherMode.OFB,
                "CTS" => CipherMode.CTS,
                _ => CipherMode.CBC,
            };
        }

        public static string Encrypt(string plainText, string key, string IV, CipherMode mode = CipherMode.CBC)
        {
            des.Key = Encoding.UTF8.GetBytes(key);
            des.IV = Encoding.UTF8.GetBytes(IV);
            des.Mode = mode;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, des.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                    cryptoStream.Write(plainBytes, 0, plainBytes.Length);
                    cryptoStream.FlushFinalBlock();
                }

                return Convert.ToBase64String(memoryStream.ToArray());
            }
            
        }

        public static string Decrypt(string encryptedText, string key, string IV, CipherMode mode = CipherMode.CBC)
        {
            des.Key = Encoding.UTF8.GetBytes(key);
            des.IV = Encoding.UTF8.GetBytes(IV);
            des.Mode = mode;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, des.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                    cryptoStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                    cryptoStream.FlushFinalBlock();
                }

                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
            
        }
    }
}
