using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TruckerApp.ViewModels.Administrator;
using TruckerApp.ExtentionMethod;

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

        /// <summary>
        /// رمز نگاری لیست کاربران
        /// </summary>
        /// <param name="viewModelUserses"></param>
        /// <returns></returns>
        Task<List<ViewModelUsers>> EncryptViewModelUser(List<ViewModelUsers> viewModelUserses);

        /// <summary>
        /// کدگشایی لیست کاربران
        /// </summary>
        /// <param name="viewModelUserses"></param>
        /// <returns></returns>
        Task<List<ViewModelUsers>> DecryptViewModelUser(List<ViewModelUsers> viewModelUserses);

    }

    public class HasherClass : IHasherClass
    {
        public HasherClass()
        {
            
        }
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

        public async Task<List<ViewModelUsers>> EncryptViewModelUser(List<ViewModelUsers> viewModelUserses)
        {
            foreach (var modelUser in viewModelUserses)
            {
                modelUser.Phone.EncryptTextUsingUtf8();
                modelUser.Roul.EncryptTextUsingUtf8();
                modelUser.username.EncryptTextUsingUtf8();
                modelUser.password = HashPassword(modelUser.password, modelUser.Phone.EncryptTextUsingUtf8());
            }
            return viewModelUserses;
        }

        public async Task<List<ViewModelUsers>> DecryptViewModelUser(List<ViewModelUsers> viewModelUserses)
        {
            foreach (var modelUser in viewModelUserses)
            {
                modelUser.Phone.DecryptTextUsingUtf8();
                modelUser.Roul.DecryptTextUsingUtf8();
                modelUser.username.DecryptTextUsingUtf8();
                modelUser.password = HashPassword(modelUser.password, modelUser.Phone.DecryptTextUsingUtf8());
            }
            return viewModelUserses;
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
