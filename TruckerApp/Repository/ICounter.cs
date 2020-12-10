using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace TruckerApp.Repository
{
    public interface ICounter:IDisposable
    {
        Task<int> packet_cnt(int seriesId);
        Task<int> faleh_cnt(int seriesId);
        Task<int> gandom_cnt(int seriesId);
        Task<int> clinker_cnt(int seriesId);
        Task<int> ahakfaleh(int seriesId);
        Task<int> ahakpackat(int seriesId);
        Task<int> othertype(int seriesId);
        Task<int> total_cnt(int seriesId);
        Task<int> packet(int seriesId);
        Task<int> faleh(int seriesId);
        Task<int> gandom(int seriesId);
        Task<int> clinker(int seriesId);
        Task<int> AhakFaleh(int seriesId);
        Task<int> AhakPackat(int seriesId);
        Task<int> OtherType(int seriesId);
        Task<int> member(int seriesId);
        Task<int> noMember(int seriesId);
        Task<int> other(int seriesId);
        Task<int> TotalCash(int seriesId);
        Task<int> TotalPOS(int seriesId);
        Task<int> SeriesCount(int seriesId);
        Task<int> lastNumber(int seriesId, byte typ);

       
        void serialBuy();
    }

    public class Counter : ICounter
    {
        private  TruckersEntities _db;

        public Counter(TruckersEntities db)
        {
            this._db = db;
        }
        public async Task<int> packet_cnt(int seriesId) => await _db.Queues.CountAsync(x => x.Type_FK == 2 && x.SeriesID_FK == seriesId && x.Status_FK == 20);
        public async Task<int> faleh_cnt(int seriesId) => await _db.Queues.CountAsync(x => x.Type_FK == 1 && x.SeriesID_FK == seriesId && x.Status_FK == 20);
        public async Task<int> gandom_cnt(int seriesId) => await _db.Queues.CountAsync(x => x.Type_FK == 3 && x.SeriesID_FK == seriesId && x.Status_FK == 20);
        public async Task<int> clinker_cnt(int seriesId) => await _db.Queues.CountAsync(x => x.Type_FK == 4 && x.SeriesID_FK == seriesId && x.Status_FK == 20);
        public async Task<int> ahakfaleh(int seriesId) => await _db.Queues.CountAsync(x => x.Type_FK == 5 && x.SeriesID_FK == seriesId && x.Status_FK == 20);
        public async Task<int> ahakpackat(int seriesId) => await _db.Queues.CountAsync(x => x.Type_FK == 6 && x.SeriesID_FK == seriesId && x.Status_FK == 20);
        public async Task<int> othertype(int seriesId) => await _db.Queues.CountAsync(x => x.Type_FK == 7 && x.SeriesID_FK == seriesId && x.Status_FK == 20);
        public async Task<int> total_cnt(int seriesId) => await _db.Queues.CountAsync(x => x.SeriesID_FK == seriesId && x.Status_FK == 20);
        public async Task<int> packet(int seriesId) => await _db.Queues.CountAsync(x => x.Type_FK == 2 && x.SeriesID_FK == seriesId);
        public async Task<int> faleh(int seriesId) => await _db.Queues.CountAsync(x => x.Type_FK == 1 && x.SeriesID_FK == seriesId);
        public async Task<int> gandom(int seriesId) => await _db.Queues.CountAsync(x => x.Type_FK == 3 && x.SeriesID_FK == seriesId);
        public async Task<int> clinker(int seriesId) => await _db.Queues.CountAsync(x => x.Type_FK == 4 && x.SeriesID_FK == seriesId);
        public async Task<int> AhakFaleh(int seriesId) => await _db.Queues.CountAsync(x => x.Type_FK == 5 && x.SeriesID_FK == seriesId);
        public async Task<int> AhakPackat(int seriesId) => await _db.Queues.CountAsync(x => x.Type_FK == 6 && x.SeriesID_FK == seriesId);
        public async Task<int> OtherType(int seriesId) => await _db.Queues.CountAsync(x => x.Type_FK == 7 && x.SeriesID_FK == seriesId);
        public async Task<int> member(int seriesId) => await _db.Queues.CountAsync(x => x.GroupCommission == 30 && x.SeriesID_FK == seriesId);
        public async Task<int> noMember(int seriesId) => await _db.Queues.CountAsync(x => x.GroupCommission == 31 && x.SeriesID_FK == seriesId);
        public async Task<int> other(int seriesId) => await _db.Queues.CountAsync(x => x.GroupCommission == 32 && x.SeriesID_FK == seriesId);
        public async Task<int> TotalCash(int seriesId) => (int) await _db.Cashes.Where(x => x.seriesID_FK == seriesId).SumAsync(x => x.CashDesk);
        public async Task<int> TotalPOS(int seriesId) => (int) await _db.Cashes.Where(x => x.seriesID_FK == seriesId).SumAsync(x => x.Pos);
        public async Task<int> SeriesCount(int seriesId) => await _db.Queues.CountAsync(x => x.SeriesID_FK == seriesId);
        public async Task<int> lastNumber(int seriesId, byte typ) =>(int) await _db.Queues.Where(x => x.SeriesID_FK == seriesId && x.Type_FK == typ).MaxAsync(x => x.Number);

        public async void serialBuy()
        {
            var qry = await _db.SeriesPrices.SingleOrDefaultAsync(x => x.enabeled == true && x.closing == false);
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
                _db.SeriesPrices.Add(series);
                _db.SaveChanges();
                PublicVar.SeriesID = series.SereisID;
                PublicVar.SeriesName = series.SeriesName;
                PublicVar.DateSerial = series.SeriesDateStart;
            }


        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}