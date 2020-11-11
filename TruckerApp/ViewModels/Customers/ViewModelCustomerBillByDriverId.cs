using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckerApp.ViewModels.Customers
{
   public class ViewModelCustomerBillByDriverId
    {
        [Display(Name = "شناسه")]
        public int ID { get; set; }
        [Display(Name = "سریال")]
        public int SerialName { get; set; }
        [Display(Name = "شماره")]
        public int Number { get; set; }
        [Display(Name = "تاریخ")]
        public string DateRegister { get; set; }
        [Display(Name = "قبض")]
        public string Bill { get; set; }
        [Display(Name = "محموله")]
        public string TypeId { get; set; }



    }
}
