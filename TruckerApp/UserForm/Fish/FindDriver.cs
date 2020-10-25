using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckerApp.UserForm.Fish
{
  public  static class FindDriver
    {
        public static Driver FindByPlate(this string resultEn,TruckersEntities db)
        {
                return  db.Drivers.FirstOrDefault(x => x.Tag == resultEn);
        }
    }
}
