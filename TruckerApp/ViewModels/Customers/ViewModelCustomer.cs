using System.ComponentModel.DataAnnotations;

namespace TruckerApp.ViewModels.Customers
{
    public class ViewModelCustomer
    {
        [Display(Name = "شناسه راننده")]
        public int DriverID { get; set; }
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [Display(Name = "تلفن همراه")]
        public string PhoneNumber { get; set; }
        [Display(Name = "کارت هوشمند")]
        public int SmartCart { get; set; }
        [Display(Name = "پلاک فارسی")]
        public string TagNumber { get; set; }
        [Display(Name = "پلاک انگلیسی")]
        public string Tag { get; set; }
        [Display(Name = "گروه عضویت")]
        public byte GroupID { get; set; }
        [Display(Name = "ایجادکننده")]
        public byte userID_FK { get; set; }
        [Display(Name = "ویرایشگر")]
        public byte? editor_FK { get; set; }
        [Display(Name = "کد راننده")]
        public int? driver_code { get; set; }
    }
}
