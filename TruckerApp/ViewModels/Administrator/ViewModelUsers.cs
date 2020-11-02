using System.ComponentModel.DataAnnotations;

namespace TruckerApp.ViewModels.Administrator
{
    public class ViewModelUsers
    {
        [Display(Name = "شناسه")]
        public byte userID { get; set; }
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [Display(Name = "فامیلی")]
        public string LastName { get; set; }
        [Display(Name = "تلفن تماس")]
        public string Phone { get; set; }
        [Display(Name = "نقش")]
        public string Roul { get; set; }
        [Display(Name = "نام کاربری")]
        public string username { get; set; }
        [Display(Name = "رمز عبور")]
        public string password { get; set; }
    }
}
