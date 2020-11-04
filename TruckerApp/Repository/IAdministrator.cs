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
        /// رمز نگاری نام کاربری و رمز عبور
        /// </summary>
        /// <returns></returns>
        Task<bool> EncryptUserTable();
        /// <summary>
        /// تبدیل پلاک های وارد شده کاربران به پلاک استاندارد ساتپا
        /// </summary>
        /// <returns></returns>
        Task<bool> ConvertPlate();


    }

    public class Administrator : IAdministrator
    {
        private readonly TruckersEntities db;

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


        public void Dispose()
        {
            db?.Dispose();
        }
    }
}
