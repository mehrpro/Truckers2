using System.ComponentModel.DataAnnotations;

namespace TruckerApp.ViewModels
{
    /// <summary>
    /// لیست خام برای گزارش براساس حواله های صادر شده فعال
    /// </summary>
    public class ViewModelReportList
    {
        [Display(Name = "ردیف")]
        public int Counter { get; set; }
        [Display(Name = "شماره")]
        public string Number { get; set; }
        [Display(Name = "نام راننده")]
        public string Name { get; set; }
        [Display(Name = "پلاک")]
        public string Tag { get; set; }
        [Display(Name = "محموله")]
        public string Typeid { get; set; }
        [Display(Name = "تلفن")]
        public string Phone { get; set; }
        [Display(Name = "قابل تمدید")]
        public string mandeh { get; set; }

    }
}