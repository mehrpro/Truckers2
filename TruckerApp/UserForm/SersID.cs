using System;
using System.Linq;

namespace TruckerApp.UserForm
{

    public class SersID
    {
        private TruckersEntities db = new TruckerApp.TruckersEntities();

        public void serid()
        {
            db = new TruckersEntities();
            var qry = db.SeriesPrices.SingleOrDefault(x => x.enabeled == true && x.closing == null);
            if (qry != null)
            {
                PublicVar.SeriesID = qry.SereisID;
                PublicVar.SeriesName = qry.SeriesName;
                PublicVar.DateSerial = qry.SeriesDateStart;
            }
            else
            {
                var series = new SeriesPrice();
                series.SeriesName =  1;
                series.SeriesDateStart = DateTime.Now;
                series.userCreator = PublicVar.UserID;
                series.enabeled = true;
                db.SeriesPrices.Add(series);
                db.SaveChanges();
            }

            
        }
        
    }
}