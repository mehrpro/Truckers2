using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckerApp.ViewModels.Queueing
{
  public   class ViewModelSeriesList
    {
        [Display(Name = "شناسه")]
        public int SereisID { get; set; }
        [Display(Name = "شماره سریال")]
        public int SeriesName { get; set; }
        [Display(Name = "زمان آغاز ")]
        public string SeriesDateStart { get; set; }
        [Display(Name = "زمان اتمام ")]
        public string SeriesDateEnd { get; set; }
        [Display(Name = "تعداد فروش")]
        public int? SeriesCount { get; set; }
        [Display(Name = "ایجاد کننده")]
        public string userCreator { get; set; }
    }
}
