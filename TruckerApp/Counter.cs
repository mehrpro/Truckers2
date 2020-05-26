using System;
using System.Linq;

namespace TruckerApp
{

    public class Counter
    {
        private TruckersEntities db = new TruckersEntities();
        public int packet_cnt(int seriesid) => db.Queues.Count(x => x.Type_FK == 2 && x.SeriesID_FK == seriesid && x.Status_FK == 20);
        public int faleh_cnt(int seriesid) => db.Queues.Count(x => x.Type_FK == 1 && x.SeriesID_FK == seriesid && x.Status_FK == 20);
        public int gandom_cnt(int seriesid) => db.Queues.Count(x => x.Type_FK == 3 && x.SeriesID_FK == seriesid && x.Status_FK == 20);
        public int clinker_cnt(int seriesid) => db.Queues.Count(x => x.Type_FK == 4 && x.SeriesID_FK == seriesid && x.Status_FK == 20);
        public int ahakfaleh(int seriesid) => db.Queues.Count(x => x.Type_FK == 5 && x.SeriesID_FK == seriesid && x.Status_FK == 20);
        public int ahakpackat(int seriesid) => db.Queues.Count(x => x.Type_FK == 6 && x.SeriesID_FK == seriesid && x.Status_FK == 20);
        public int othertype(int seriesid) => db.Queues.Count(x => x.Type_FK == 7 && x.SeriesID_FK == seriesid && x.Status_FK == 20);



        public int total_cnt(int seriesid) => db.Queues.Count(x=> x.SeriesID_FK == seriesid && x.Status_FK == 20);
        public int packet(int seriesid) => db.Queues.Count(x => x.Type_FK == 2 && x.SeriesID_FK == seriesid);
        public int faleh(int seriesid) => db.Queues.Count(x => x.Type_FK == 1 && x.SeriesID_FK == seriesid);

        public int gandom(int seriesid) => db.Queues.Count(x => x.Type_FK == 3 && x.SeriesID_FK == seriesid);
        public int clinker(int seriesid) => db.Queues.Count(x => x.Type_FK == 4 && x.SeriesID_FK == seriesid);
        public int AhakFaleh(int seriesid) => db.Queues.Count(x => x.Type_FK == 5 && x.SeriesID_FK == seriesid);
        public int AhakPackat(int seriesid) => db.Queues.Count(x => x.Type_FK == 6 && x.SeriesID_FK == seriesid);
        public int OtherType(int seriesid) => db.Queues.Count(x => x.Type_FK == 7 && x.SeriesID_FK == seriesid);
        public short member(int seriesid) => (short)db.Queues.Count(x => x.GroupCommission == 30 && x.SeriesID_FK == seriesid);
        public short noMember(int seriesid) => (short)db.Queues.Count(x => x.GroupCommission == 31 && x.SeriesID_FK == seriesid);
        public short other(int seriesid) => (short)db.Queues.Count(x => x.GroupCommission == 32 && x.SeriesID_FK == seriesid);
        public int TotalCash(int seriesid)
        {
          var qry =   db.Cashes.Where(x => x.seriesID_FK == seriesid).ToList();
          if (qry != null) return qry.Sum(x => x.CashDesk.Value); 
          return 0;
        }
        public int TotalPOS(int seriesid)
        {
            var qry = db.Cashes.Where(x => x.seriesID_FK == seriesid).ToList();
            if (qry != null) return qry.Sum(x => x.Pos.Value);
            return 0;
        }
        public int SeriesCount(int seriesid) => db.Queues.Count(x => x.SeriesID_FK == seriesid);
        public int lastNumber(int seriesID,byte typ)
        {
            var max = db.Queues.Where(x => x.SeriesID_FK == seriesID && x.Type_FK ==typ).ToList();
            if (max.Count == 0) return 0;
            return max.Max(x => x.Number);
        }
        public void serialBuy()
        {
            db = new TruckersEntities();
            var qry = db.SeriesPrices.SingleOrDefault(x => x.enabeled == true && x.closing == false);
            if (qry != null)
            {
                PublicVar.SeriesID = qry.SereisID;
                PublicVar.SeriesName = qry.SeriesName;
                PublicVar.DateSerial = qry.SeriesDateStart;
            }
            else
            {
                var series = new SeriesPrice();
                series.SeriesName = 1;
                series.SeriesDateStart = DateTime.Now;
                series.userCreator = PublicVar.UserID;
                series.enabeled = true;
                series.closing = false;
                db.SeriesPrices.Add(series);
                db.SaveChanges();
                PublicVar.SeriesID = series.SereisID;
                PublicVar.SeriesName = series.SeriesName;
                PublicVar.DateSerial = series.SeriesDateStart;
            }


        }
    }
}