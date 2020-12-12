using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckerApp.ViewModels.Administrator;

using TruckerApp.ExtentionMethod;



namespace TruckerApp.Repository
{
    public interface IAdministrator : IDisposable
    {
        /// <summary>
        /// احراز هویت کاربر
        /// </summary>
        /// <param name="viewModelLogin">اطلاعات کاربری</param>
        /// <returns></returns>
        DialogResult ApproveLogin(ViewModelLogin viewModelLogin);
        /// <summary>
        /// ساخت لیست صف بندی
        /// </summary>
        /// <returns></returns>
        Task<bool> CreateScheduleList();

        /// <summary>
        /// افزودن کاربر جدید
        /// </summary>
        /// <param name="modelUsers">مدل کاربر</param>
        /// <returns></returns>
        Task<bool> ManageUsers(User user);
        /// <summary>
        /// لیست کاربران سیستم
        /// </summary>
        /// <returns></returns>
        Task<List<ViewModelUsers>> GetAllUser();
        /// <summary>
        /// لیست کاربران برای صفحه ورود
        /// </summary>
        /// <returns></returns>
        Task<List<string>> GetAllUserForLogin();
        /// <summary>
        /// رمز نگاری نام کاربری و رمز عبور
        /// </summary>
        /// <returns></returns>
        Task<bool> EncryptUserTable();
        /// <summary>
        /// تبدیل پلاک های وارد شده کاربران به پلاک استاندارد ساتپا
        /// </summary>
        /// <returns></returns>
        Task<bool> ConvertPlate();
        /// <summary>
        /// راننده اتفاقی برای تست
        /// </summary>
        /// <returns></returns>
        Task<Driver> RandomDriver();

        /// <summary>
        ///  ثبت شماره حساب بانکی
        /// </summary>
        /// <param name="bankAccNum"></param>
        /// <returns></returns>
        Task<bool> AddNewBankAccNumber(BankAccNum bankAccNum);
        /// <summary>
        /// ویرایش شماره حساب بانکی
        /// </summary>
        /// <param name="bankAccNum"></param>
        /// <returns></returns>
        Task<bool> EditBankAccNumber(BankAccNum bankAccNum);

        /// <summary>
        /// لیست شماره حساب های بانکی
        /// </summary>
        /// <returns></returns>
        Task<List<BankAccNum>> GatAllBankNumber();

        /// <summary>
        /// اصلاح پلاک فارسی
        /// </summary>
        /// <returns></returns>
        Task<bool> ConvertPlateFarsi();




    }

    public class Administrator : IAdministrator
    {
        private  TruckersEntities db;

        public Administrator(TruckersEntities db)
        {
            this.db = db;

        }

        public DialogResult ApproveLogin(ViewModelLogin viewModelLogin)
        {
            var usr = viewModelLogin.UserName.EncryptTextUsingUtf8();
            var pass = viewModelLogin.Password.EncryptTextUsingUtf8();
            var qryUser = db.Users.FirstOrDefault(x => x.username == usr);
            if (qryUser != null)
            {
                if (qryUser.password.Trim() == pass)
                {
                    PublicVar.userMode = qryUser.Roul.Trim();
                    PublicVar.UserID = qryUser.userID;
                    PublicVar.OpreatorName = $"{qryUser.FirstName} {qryUser.LastName}";
                    return DialogResult.OK;
                }
            }
            return DialogResult.Abort;
        }

        public async Task<bool> CreateScheduleList()
        {
            try
            {
                for (byte i = 101; i < 108; i++)
                {
                    var qry = await db.LoadTypes.FindAsync(i);
                    if (qry == null)
                    {
                        var newSchType = new LoadType()
                        {
                            TypeID = i,
                            Type = "0"
                        };
                        db.LoadTypes.Add(newSchType);
                    }
                }
                await db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<bool> ManageUsers(User user)
        {
            try
            {
                var local = db.Set<User>().Local.FirstOrDefault(f => f.userID == user.userID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                if (user.userID == 0)
                {
                    db.Entry(user).State = EntityState.Added;
                    await db.SaveChangesAsync();
                    return true;
                }
                db.Entry(user).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception exception)
            {
                var e = exception.Message;
                return false;
            }
        }

        public async Task<List<ViewModelUsers>> GetAllUser()
        {
            var qry = await db.Users.ToListAsync();
            var list = new List<ViewModelUsers>();
            foreach (var user in qry)
            {
                list.Add(new ViewModelUsers
                {
                    userID = user.userID,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Phone = user.Phone,
                    Roul = user.Roul,
                    username = user.username.DecryptTextUsingUtf8(),
                    password = user.password.DecryptTextUsingUtf8(),
                });
            }

            return list;
        }

        public async Task<List<string>> GetAllUserForLogin()
        {
            var qry = await db.Users.ToListAsync();
            var list = new List<string>();
            foreach (var item in qry)
            {
                list.Add(item.username.DecryptTextUsingUtf8());
            }
            return list;
        }

        public async Task<bool> EncryptUserTable()
        {
            var qryUser = await db.Users.ToListAsync();
            foreach (var user in qryUser)
            {
                user.password = user.password.Trim().EncryptTextUsingUtf8();
                user.username = user.username.Trim().EncryptTextUsingUtf8();
            }

            await db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ConvertPlate()
        {
            try
            {
                var qry = await db.Drivers.ToListAsync();
                foreach (var plate in qry)
                {
                    var temp = plate.TagNumber.ToCharArray();
                    if (temp[3] == 'ع' && plate.Tag.Length < 5)
                    {
                        temp[3] = 'A';
                        plate.Tag = $"{temp[4]}{temp[5]}-Ain-{temp[0]}{temp[1]}{temp[2]}{plate.Tag}";
                    }
                }
                await db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<Driver> RandomDriver()
        {
            var max = db.Drivers.Max(x => x.DriverID);
            Random rnd = new Random();
            var result = new Driver();
            do
            {
                int randomNext = rnd.Next(1, max); 
                result = await db.Drivers.SingleOrDefaultAsync(x => x.DriverID == randomNext);
            } while (result == null);
            return result;
        }

        public async Task<bool> AddNewBankAccNumber(BankAccNum bankAccNum)
        {
            try
            {
                db.Entry(bankAccNum).State = EntityState.Added;
                await db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> EditBankAccNumber(BankAccNum bankAccNum)
        {
            try
            {
                db.Entry(bankAccNum).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<BankAccNum>> GatAllBankNumber()
        {
          return await db.BankAccNums.ToListAsync();
        }

        public async Task<bool> ConvertPlateFarsi()
        {
            try
            {
                await db.Drivers.ForEachAsync(item => Action(item));
                await db.SaveChangesAsync();
                return true;
            }
            catch 
            {
                return false;
            }

        }

        private void Action(Driver obj)
        {
            //1 2 3 4 5 6 7 8 9 10 11 12
            //1 2 - A i n - 8 9 10 11 12
            var tag = obj.Tag.ToCharArray();
            if (tag.Length == 12)
            {
                obj.TagNumber = $"ایران {tag[10]}{tag[11]} {tag[7]}{tag[8]}{tag[9]}ع{tag[0]}{tag[1]}";
            }
            else
            {
                obj.TagNumber = "No_Set";
            }

        }


        public void Dispose()
        {
            db?.Dispose();
        }
    }
}
