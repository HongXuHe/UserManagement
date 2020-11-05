using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace UserManagement.Utility
{
    public class Md5Encrypt
    {
        /// <summary>
        /// encrypt string to md5 string
        /// </summary>
        /// <param name="input">origional input</param>
        /// <returns>Md5 string</returns>
        public static string GetMD5Hash(string input)
        {
            //using (MD5 md5Hash = MD5.Create())
            //{
            //    byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            //    StringBuilder sBuilder = new StringBuilder();
            //    for (int i = 0; i < (data.Length); i++)
            //    {
            //        sBuilder.Append(data[i].ToString("x2"));
            //    }
            //    return sBuilder.ToString();
            //}
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
