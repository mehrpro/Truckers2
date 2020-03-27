using System.Linq;

namespace TruckerApp
{
    public class SeriesClass
    {
        TruckersEntities db = new TruckersEntities();

        public int LastSeries()
        {
            return db.SeriesPrices.Single(x => x.enabeled == true && x.closing == false).SeriesName;
        }
        public int TotalFaleh(int id)
        {
            int result = 0;

            return result;
        }
    }
}