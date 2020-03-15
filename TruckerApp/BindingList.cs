using System.Collections.Generic;
using System.Linq;

namespace TruckerApp
{
    public class BindingList
    {
        TruckersEntities db = new TruckersEntities();
        public List<Driver> DriversList() => db.Drivers.ToList();
        public List<Driver> DriversMembers() => db.Drivers.Where(x => x.GroupID == 30).ToList();
    }
}