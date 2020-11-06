using System.ComponentModel.DataAnnotations;

namespace TruckerApp.ViewModels.Queueing
{
    /// <summary>
    /// لیست برای نمایش در گزارش روزانه فروش
    /// </summary>
  public  class ViewModelQueueBySeriesId
    {
        [Display(Name = "شماره")]
        public int Number { get; set; }
        [Display(Name = "کارت هوشمند")]
        public string SmartCart { get; set; }
        [Display(Name = "راننده")]
        public string FullName { get; set; }
        [Display(Name = "محموله")]
        public string Cargo { get; set; }
        [Display(Name = "کمیسیون")]
        public string Commission { get; set; }
        [Display(Name = "پلاک")]
        public string Tag { get; set; }

    }
}
