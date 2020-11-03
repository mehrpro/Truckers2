using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckerApp.ViewModels.Customers
{
    public class ViewMoelTransformerTel
    {
        public string Fname { get; set; }
        public string LName { get; set; }
        public string Mobile { get; set; }
        public string Jobs { get; set; }
        public Nullable<int> DriverID_FK { get; set; }
    }
}
