using System.ComponentModel.DataAnnotations;

namespace TruckerApp.ViewModels.Customers
{
    public class ViewModelCustomerForComboBox
    {
        [Display(Name = "شناسه راننده")]
        public int DriverID { get; set; }
        [Display(Name = "راننده")]
        public string FullName { get; set; }
        [Display(Name = "تلفن همراه")]
        public string PhoneNumber { get; set; }
        [Display(Name = "شماره هوشمند")]
        public int SmartCart { get; set; }
    }
}
