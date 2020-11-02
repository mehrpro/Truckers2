using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TruckerApp.Repository
{
    public interface IHasherClass
    {
        /// <summary>
        /// ساخت کلید برای رمز نگاری
        /// </summary>
        /// <returns></returns>
        string NewGuidForSalt();
        /// <summary>
        /// ترکیب رمز عبور با کلید ثانویه و ساخت رمز هش شده
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        string HashPassword(string password, string salt);
        /// <summary>
        /// تایید پسورد 
        /// </summary>
        /// <param name="password">رمز عبور دریافتی از کاربر</param>
        /// <param name="salt">کلید ثانویه رمزنگار</param>
        /// <param name="hash">پسورد رمز شده در بانک اطلاعاتی</param>
        /// <returns></returns>
        bool CheckPassword(string password, string salt, string hash);
    }

    public class HasherClass : IHasherClass
    {
        public string NewGuidForSalt()
        {
            return Guid.NewGuid().ToString("N");
        }

        public string HashPassword(string password, string salt)
        {
            var combined = password + salt + password;
            return HashString(combined);
        }

        public bool CheckPassword(string password, string salt, string hash)
        {
            return HashPassword(password, salt).Equals(hash);
        }

        private string HashString(string toHash)
        {
            using (var sha512 = new SHA512CryptoServiceProvider())
            {
                byte[] dataToHash = Encoding.UTF8.GetBytes(toHash);
                byte[] hashed = sha512.ComputeHash(dataToHash);
                return Convert.ToBase64String(hashed);
            }
        }
    }
}
