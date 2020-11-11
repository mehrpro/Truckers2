using System.ComponentModel.DataAnnotations;

namespace TruckerApp.ViewModels.Administrator
{
  public  class ViewModelBankAccNumber
    {
        [Display(Name = "شناسه")]
        public int ID { get; set; }
        [Display(Name = "مالک حساب")]
        public string FullName { get; set; }
        [Display(Name = "نام بانک")]
        public string BankName { get; set; }
        [Display(Name = "شماره حساب")]
        public string AccNumber { get; set; }
        [Display(Name = "شماره کارت")]
        public string AccCart { get; set; }
        [Display(Name = "شماره شبا")]
        public string AccISBN { get; set; }
        [Display(Name = "ایجاد کننده")]
        public string Editor { get; set; }
    }
}
