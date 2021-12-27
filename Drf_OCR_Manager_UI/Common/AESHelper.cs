using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Drf_OCR_Manager_UI.Common
{
    public class AESHelper
    {
        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="toEncrypt"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string AesPythonEncrypt(string toEncrypt, string key)
        {
            var keyArray = SHAPython256(key);
            var toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);
            byte[] iv = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var rDel = new RijndaelManaged
            {
                Key = keyArray,
                IV = iv,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                BlockSize = 128
            };
            var cTransform = rDel.CreateEncryptor();
            var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        public static byte[] SHAPython256(string str)
        {
            var SHA256Data = Encoding.UTF8.GetBytes(str);
            var Sha256 = new SHA256Managed();
            var by = Sha256.ComputeHash(SHA256Data);
            return by;
        }

        /// <summary> 
        /// AES解密
        /// </summary> 
        /// <param name="decryptStr">密文</param> 
        /// <param name="key">密钥</param> 
        /// <returns></returns> 
        public static string Decrypt(string decryptStr, string key)
        {
            var _aes = new AesCryptoServiceProvider();
            _aes.BlockSize = 128;
            _aes.KeySize = 256;
            byte[] iv = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var keyArray = SHAPython256(key);
            _aes.Key = keyArray;
            _aes.IV = iv;//Encoding.UTF8.GetBytes(IV);
            _aes.Padding = PaddingMode.PKCS7;
            _aes.Mode = CipherMode.CBC;

            var _crypto = _aes.CreateDecryptor(_aes.Key, _aes.IV);
            byte[] decrypted = _crypto.TransformFinalBlock(
                System.Convert.FromBase64String(decryptStr), 0, System.Convert.FromBase64String(decryptStr).Length);
            _crypto.Dispose();
            return Encoding.UTF8.GetString(decrypted);
        }

    }
}