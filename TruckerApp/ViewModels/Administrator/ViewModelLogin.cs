using System.ComponentModel.DataAnnotations;

namespace TruckerApp.ViewModels.Administrator
{
    public class ViewModelLogin
    {
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

    }
}
