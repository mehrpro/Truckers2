using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckerApp.ViewModels.Administrator;

namespace TruckerApp.Repository
{
    public interface IAdministrator
    {
        /// <summary>
        /// احراز هویت کاربر
        /// </summary>
        /// <param name="viewModelLogin">اطلاعات کاربری</param>
        /// <returns></returns>
        Task<DialogResult> ApproveLogin(ViewModelLogin viewModelLogin);
    }

    public class Administrator : IAdministrator
    {
        private readonly TruckersEntities db;

        public Administrator(TruckersEntities db)
        {
            this.db = db;
        }

        public async Task<DialogResult> ApproveLogin(ViewModelLogin viewModelLogin)
        {
            var qryUser = await db.Users.FirstOrDefaultAsync(x => x.username.Trim() == viewModelLogin.UserName);
            if (qryUser != null)
            {
                if (qryUser.password.Trim() == viewModelLogin.Password)
                {
                    PublicVar.userMode = qryUser.Roul.Trim();
                    PublicVar.UserID = qryUser.userID;
                    PublicVar.OpreatorName = $"{qryUser.FirstName} {qryUser.LastName}";
                    return DialogResult.OK;
                }
            }
            return DialogResult.Abort;
        }
    }
}
