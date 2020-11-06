using System.ComponentModel.DataAnnotations;

namespace TruckerApp.ViewModels
{
    public class ViewModelQueue
    { 
        [Display(Name = "شماره")]
        public short Number { get; set; }
        [Display(Name = "عضویت")]
        public byte GroupCommission { get; set; }
        [Display(Name = "شناسه بار")]
        public byte TypeFk { get; set; }
        [Display(Name = "تاریخ ثبت")]
        public System.DateTime DateTimeRegister { get; set; }
        [Display(Name = "شناسه راننده")]
        public int DriverIdFk { get; set; }
        [Display(Name = "وضعیت")]
        public byte StatusFk { get; set; }
        [Display(Name = "شناسه کمیسیون")]
        public short ComosiunIdFk { get; set; }
        [Display(Name = "شناسه سریال فروش")]
        public int SeriesIdFk { get; set; }
        [Display(Name = "قابل تمدید")]
        public bool? Mandeh { get; set; }
    }
}
