﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TruckerApp.ExtentionMethod
{
   public static class CryptoClass
    {
        public static string EncryptTextUsingUtf8(this string strText)
        {
            return EncryptUsingUtf8(strText, "&)**)!@(");
        }
        public static string DecryptTextUsingUtf8(this string strText)
        {
            return DecryptUsingUtf8(strText, "&)**)!@(");
        }


        private static string DecryptUsingUtf8(string strText, string sDecrKey)
        {
            byte[] byKey = {

            };
            byte[] IV = {
                0x12,
                0x34,
                0x56,
                0x78,
                0x90,
                0xab,
                0xcd,
                0xef
            };
            byte[] inputByteArray = new byte[strText.Length + 1];

            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(sDecrKey.ToString().Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArray = Convert.FromBase64String(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);

                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                System.Text.Encoding encoding = System.Text.Encoding.UTF8;

                return encoding.GetString(ms.ToArray());

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private static string EncryptUsingUtf8(string strText, string strEncrKey)
        {
            byte[] byKey = {

            };
            byte[] IV = {
                0x12,
                0x34,
                0x56,
                0x78,
                0x90,
                0xab,
                0xcd,
                0xef
            };

            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(strEncrKey.Substring(0, 8));

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.UTF8.GetBytes(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

    }
}
