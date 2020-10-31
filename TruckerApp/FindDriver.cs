using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckerApp
{
  public  static class FindDriver
    {
        public static Driver FindByPlate(this string resultEn,TruckersEntities db)
        {
                return  db.Drivers.FirstOrDefault(x => x.Tag == resultEn);
        }
        public static bool CheckPlateAny(this string plateEn, TruckersEntities db)
        {
            return db.Drivers.Any(x => x.Tag == plateEn);
        }

        public static bool CheckSmartID(this int samartid, TruckersEntities db)
        {
            return db.Drivers.Any(x => x.SmartCart == samartid);
        }
       
    }
}
