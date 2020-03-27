﻿using System;
using System.Linq;

namespace TruckerApp
{

    public class Counter
    {
        private TruckersEntities db = new TruckersEntities();
        public int packet(int seriesid) => db.Queues.Count(x => x.Type_FK == 2 && x.SeriesID_FK == seriesid);
        public int faleh(int seriesid) => db.Queues.Count(x => x.Type_FK == 1 && x.SeriesID_FK == seriesid);
        public int gandom(int seriesid) => db.Queues.Count(x => x.Type_FK == 3 && x.SeriesID_FK == seriesid);
        public int clinker(int seriesid) => db.Queues.Count(x => x.Type_FK == 4 && x.SeriesID_FK == seriesid);
        public short member(int seriesid) => (short)db.Queues.Count(x => x.GroupCommission == 30 && x.SeriesID_FK == seriesid);
        public short noMember(int seriesid) => (short)db.Queues.Count(x => x.GroupCommission == 31 && x.SeriesID_FK == seriesid);
        public short other(int seriesid) => (short)db.Queues.Count(x => x.GroupCommission == 32 && x.SeriesID_FK == seriesid);
        public int SeriesCount(int seriesid) => db.Queues.Count(x => x.SeriesID_FK == seriesid);
        public int LastSeriesNum() => db.SeriesPrices.Max(x => x.SeriesName);
        public int? LastSeriesID()=> db.SeriesPrices.SingleOrDefault(x => x.enabeled == true && x.closing == false).SereisID;
        public int lastNumber(int seriesID)
        {
            var max = db.Queues.Where(x => x.SeriesID_FK == seriesID).ToList();
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