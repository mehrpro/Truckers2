using System.ComponentModel.DataAnnotations;

namespace TruckerApp.UserForm.cash
{
    public class TotalCashList
    {
        [Display(Name = "تاریخ")]
        public string DateTime { get; set; }
        [Display(Name = "سریال")]
        public int SeriesName { get; set; }
        [Display(Name = " صندوق ")]
        public long TotalCash { get; set; }
        [Display(Name = " کارت خوان")]
        public long TotalPos { get; set; }
        [Display(Name = "سیمان فله")]
        public int faleh { get; set; }
        [Display(Name = "سیمان پاکت")]
        public int packat { get; set; }
        [Display(Name = "غلات")]
        public int gandom { get; set; }
        [Display(Name = "کلینکر")]
        public int clinker { get; set; }
        [Display(Name = "آهک فله")]
        public int AhakFaleh { get; set; }
        [Display(Name = "آهک پاکت")]
        public int AhakPackat { get; set; }
        [Display(Name = "متفرقه")]
        public int Othertype { get; set; }
  

    }
}