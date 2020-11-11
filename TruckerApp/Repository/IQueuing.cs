using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckerApp.ExtentionMethod;
using TruckerApp.ViewModels;
using TruckerApp.ViewModels.Queueing;

namespace TruckerApp.Repository
{
    public interface IQueuing : IDisposable
    {
        /// <summary>
        /// لیست نوع محموله
        /// </summary>
        /// <returns></returns>
        Task<List<ViewModelCargoType>> GetAllCargoType();
        /// <summary>
        /// آخرین شماره نوبت براساس نوع محموله
        /// </summary>
        /// <param name="typeId">شناسه نوع بار</param>
        /// <returns></returns>
        Task<int> GetLastNumberByTypeId(byte typeId);
        /// <summary>
        /// کمیسیون راننده براساس نوع عضویت و نوع محموله
        /// </summary>
        /// <param name="typeId">شناسه نوع بار</param>
        /// <param name="groupId">شناسه گروه عضویت</param>
        /// <returns></returns>
        Task<Commission> GetCommisinoByTypeIdAndByGroupId(byte typeId, byte groupId);
        /// <summary>
        /// جستجو پلاک در بانک اطلاعاتی
        /// </summary>
        /// <param name="resultEn">پلاک با فرمت انگلیسی</param>
        /// <returns></returns>
        Driver FindByPlate(string resultEn);
        /// <summary>
        /// جستجو حواله ی فعال براساس پلاک خودرو
        /// </summary>
        /// <param name="tag">پلاک با فرمت انگلیسی</param>
        /// <returns></returns>
        Task<Queue> FindByQueue(string tag);
        /// <summary>
        /// جستجوی حواله ی فعال براساس شناسه راننده
        /// </summary>
        /// <param name="driverId">شناسه راننده</param>
        /// <returns></returns>
        Task<Queue> FindByQueue(int driverId);
        /// <summary>
        /// صدور نوبت جدید و مبلغ دریافتی صندوق
        /// </summary>
        /// <param name="viewModelQueue">موجودیت و اطلاعات نوبت</param>
        /// <param name="viewModelCash">موجودیت و اطلاهات صندوق دریافتی</param>
        /// <returns></returns>
        bool RegisterNewQueue(ViewModelQueue viewModelQueue, ViewModelCash viewModelCash);
        /// <summary>
        /// مجموع سفارشات بر اساس سریال فروش
        /// </summary>
        /// <param name="typeId">شناسه محموله</param>
        /// <param name="serieseId">شناسه سریال فروش</param>
        /// <returns></returns>
        Task<int> TotalTypeByTypeId(byte typeId, int serieseId);
        /// <summary>
        /// مجموع گروه های رانندگان براساس سریال فروش
        /// </summary>
        /// <param name="groupId">شناسه گروه  رانندگان</param>
        /// <param name="serieseId">شناسه سریال فروش</param>
        /// <returns></returns>
        Task<int> TotalGroupByGroupId(byte groupId, int serieseId);
        /// <summary>
        /// لیست نوبت های صادر شده بر اساس سریال فروش
        /// </summary>
        /// <param name="serieseId">شناسه سریال فروش</param>
        /// <returns></returns>
        Task<List<ViewModelQueueBySeriesId>> GetQueueListBySeriesId(int serieseId);
        /// <summary>
        /// لیست سریال فروش های صادر شده
        /// </summary>
        /// <returns></returns>
        Task<List<ViewModelSeriesList>> GetSeriesList();
        /// <summary>
        /// ابطال یا بازگشت وجه و ابطال نوبت براساس شناسه نوبت
        /// </summary>
        /// <param name="queueId">شناسه نوبت</param>
        /// <param name="typeId">شناسه علت ابطال</param>
        /// <returns></returns>
        Task<bool> RetrunCashByQueueID(int queueId, byte typeId);
        /// <summary>
        /// رسید تکی حواله
        /// </summary>
        /// <param name="queueId">شناسه حواله صادره شده</param>
        /// <returns></returns>
        Task<bool> ResieadByQueueID(int queueId);
        /// <summary>
        /// ایجاد سریال فروش جدید و ثبت تعدادی دفاتر
        /// </summary>
        /// <returns></returns>
        bool NewSerial();
        /// <summary>
        /// آخرین سریال فروش صادر شده
        /// </summary>
        /// <returns></returns>
        Task<SeriesPrice> LastSerial();
        /// <summary>
        /// بارگذاری سریال فروش فعال
        /// </summary>
        /// <returns></returns>
        Task<bool> LoadLastSerial();
        /// <summary>
        /// صفر کردن لیست نوبت انتظار
        /// </summary>
        /// <returns></returns>
        Task<bool> ResetScheduleList();
        /// <summary>
        /// شمارش مجدد نوبت انتظار
        /// </summary>
        /// <returns></returns>
        Task<bool> CounterScheduleList();
        /// <summary>
        /// شماره نوبت براساس نوع محموله
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        Task<string> GetScheduleByTypeId(byte typeId);
        /// <summary>
        /// شناسه راننده 
        /// </summary>
        /// <param name="tag">پلاک انگلیسی</param>
        /// <returns></returns>
        int RetrunDirverID(string tag);
        /// <summary>
        /// نوبت های تمدید نشده
        /// </summary>
        /// <returns></returns>
        Task<List<Queue>> GetTamdid();
        /// <summary>
        /// تمدید نوبت
        /// </summary>
        /// <param name="queueId"></param>
        /// <returns></returns>
        Task<bool> Tamdid(int queueId);
        /// <summary>
        /// تغییر وضعیت کاربری
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        Task<bool> Change23to20(int driver);

    }

    public class Queuing : IQueuing
    {
        private TruckersEntities _db;
        public Queuing(TruckersEntities db)
        {
            this._db = db;
        }
        public async Task<List<ViewModelCargoType>> GetAllCargoType()
        {
            var qryCargoType = await _db.LoadTypes.Where(x => x.TypeID < 10).ToListAsync();
            var listResult = new List<ViewModelCargoType>();
            foreach (var type in qryCargoType)
            {
                listResult.Add(new ViewModelCargoType
                {
                    TypeID = type.TypeID,
                    Type = type.Type
                });
            }

            return listResult;
        }
        public async Task<int> GetLastNumberByTypeId(byte typeId)
        {
            var max = await _db.Queues.Where(x => x.SeriesID_FK == PublicVar.SeriesID && x.Type_FK == typeId).ToListAsync();
            if (max.Count == 0) return 1;
            return max.Max(x => x.Number) + 1;
        }
        private async Task<Commission> GetCommissionByGroupId(byte groupId)
        {
            return await _db.Commissions.SingleOrDefaultAsync(x => x.enabled && x.Groups_FK == groupId);
        }
        public async Task<Commission> GetCommisinoByTypeIdAndByGroupId(byte typeId, byte groupId)
        {
            if (groupId != 32)//بومی
            {
                if (groupId == 30)//عضو 
                {
                    if (typeId == 4)//کلینکر
                        return await GetCommissionByGroupId(13);
                    return await GetCommissionByGroupId(14);
                }

                if (groupId == 31)//غیر عضو 
                {
                    if (typeId == 4)// کلینکر
                        return await GetCommissionByGroupId(17);
                    return await GetCommissionByGroupId(15);

                }
            }
            else//غیر بومی
            {
                if (typeId == 4)//کلینکر
                    return await GetCommissionByGroupId(18);
                return await GetCommissionByGroupId(16);
            }

            return null;
        }
        public Driver FindByPlate(string resultEn)
        {
            return _db.Drivers.FirstOrDefault(x => x.Tag == resultEn);
        }
        public async Task<Queue> FindByQueue(string tag)
        {
            var result = RetrunDirverID(tag);
            return result > 0? await _db.Queues.SingleOrDefaultAsync(x => x.Status_FK == 20 && x.DriverID_FK == result): null;
        }

        public async Task<Queue> FindByQueue(int driverId)
        {
            return await _db.Queues.SingleOrDefaultAsync(x => x.DriverID_FK == driverId && x.Status_FK == 20);
        }

        public bool RegisterNewQueue(ViewModelQueue viewModelQueue, ViewModelCash viewModelCash)
        {
            try
            {
                using (var tran = _db.Database.BeginTransaction())
                {
                    var newQueue = new Queue();
                    newQueue.Number = viewModelQueue.Number;
                    newQueue.GroupCommission = viewModelQueue.GroupCommission;
                    newQueue.Type_FK = viewModelQueue.TypeFk;
                    newQueue.DateTimeRegister = viewModelQueue.DateTimeRegister;
                    newQueue.DriverID_FK = viewModelQueue.DriverIdFk;
                    newQueue.Status_FK = viewModelQueue.StatusFk;
                    newQueue.ComosiunID_FK = viewModelQueue.ComosiunIdFk;
                    newQueue.SeriesID_FK = viewModelQueue.SeriesIdFk;
                    newQueue.mandeh = (bool) viewModelQueue.Mandeh;
                    _db.Queues.Add(newQueue);
                    _db.SaveChanges();
                    var newCash = new Cash
                    {
                        QueueID_FK = newQueue.ID,
                        Pos = Convert.ToInt32(viewModelCash.Pos),
                        CashDesk = Convert.ToInt32(viewModelCash.CashDesk),
                        userID = PublicVar.UserID,
                        seriesID_FK = newQueue.SeriesID_FK,
                    };
                    _db.Cashes.Add(newCash);
                    _db.SaveChanges();
                    tran.Commit();
                    return true;
                };
            }
            catch
            {
                return false;
            }
        }
        public async Task<int> TotalTypeByTypeId(byte typeId, int serieseId)
        {
            return await _db.Queues.CountAsync(x => x.SeriesID_FK == serieseId && x.Type_FK == typeId);
        }

        public async Task<int> TotalGroupByGroupId(byte groupId, int serieseId)
        {
            return await _db.Queues.CountAsync(x => x.SeriesID_FK == serieseId && x.GroupCommission == groupId);
        }

        //private void RefreshAll()
        //{
        //    foreach (var entity in db.ChangeTracker.Entries())
        //    {
        //        entity.Reload();
        //    }
        //}
        public async Task<List<ViewModelQueueBySeriesId>> GetQueueListBySeriesId(int serieseId)
        {
            _db = new TruckersEntities();
            //db.Entry(typeof(Queue)).Reload();
            //db.Refresh(RefreshMode.StoreWins, yourEntity);

            //RefreshAll();

            var qry = await _db.Queues.Where(x => x.SeriesID_FK == serieseId).ToListAsync();
            var list = new List<ViewModelQueueBySeriesId>();
            foreach (var queue in qry)
            {
                var id = new ViewModelQueueBySeriesId();
                id.Number = queue.Number;
                id.SmartCart = queue.Driver.SmartCart.ToString();
                id.FullName = $"{queue.Driver.FirstName} {queue.Driver.LastName}";
                id.Cargo = queue.LoadType.Type;
                id.Commission = queue.Commission.CommissionPrice.ToString();
                id.Tag = queue.Driver.Tag;
                list.Add(id);
            }

            return list.OrderBy(x => x.Cargo).ToList();
        }

        public async Task<List<ViewModelSeriesList>> GetSeriesList()
        {
            var qry = await _db.SeriesPrices.ToListAsync();
            var list = new List<ViewModelSeriesList>();

            foreach (var seriesPrice in qry)
            {
                var item = new ViewModelSeriesList();
                item.SereisID = seriesPrice.SereisID;
                item.SeriesName = seriesPrice.SeriesName;
                item.SeriesDateStart = seriesPrice.SeriesDateStart.PersianConvertor();
                item.SeriesCount = seriesPrice.SeriesCount;
                item.SeriesDateEnd = seriesPrice.SeriesDateEnd == null ? "" : seriesPrice.SeriesDateEnd.Value.PersianConvertor();
                item.userCreator = $"{seriesPrice.User.FirstName} {seriesPrice.User.LastName}";
                list.Add(item);
            }
            return list.OrderByDescending(x=>x.SeriesName).ToList();
        }

        public async Task<bool> RetrunCashByQueueID(int queueId, byte typeId)
        {
            using (var trans = _db.Database.BeginTransaction())
            {
                try
                {
                    var qry = _db.Cashes.Single(x => x.QueueID_FK == queueId);
                    var qryQueue = _db.Queues.Single(x => x.ID == queueId);
                    qryQueue.Status_FK = typeId;
                    qry.Pos = qry.CashDesk = 0;
                    await _db.SaveChangesAsync();
                    trans.Commit();
                    return true;
                }
                catch
                {
                    return false;
                }
            }



        }

        public async Task<bool> ResieadByQueueID(int queueId)
        {
            try
            {
                var qryQueue = await _db.Queues.SingleOrDefaultAsync(x => x.ID == queueId);
                if (qryQueue == null)
                    return false;
                qryQueue.Status_FK = 23;
                await _db.SaveChangesAsync();
                return true;

            }
            catch
            {
                return false;
            }

        }

        public bool NewSerial()
        {
            using (var ts = _db.Database.BeginTransaction())
            {
                try
                {
                    var last = _db.SeriesPrices.SingleOrDefault(x => x.enabeled == true && x.closing == false);
                    if (last == null)
                    {
                        //NewSerial
                        return false;
                    }

                    if (_db.Cashes.FirstOrDefault(x => x.seriesID_FK == last.SereisID) == null)
                    {
                        return false;
                    }
                    last.SeriesDateEnd = DateTime.Now;
                    last.Faleh = _db.Queues.Count(x => x.Type_FK == 1 && x.SeriesID_FK == last.SereisID);
                    last.Packet = _db.Queues.Count(x => x.Type_FK == 2 && x.SeriesID_FK == last.SereisID);
                    last.Gandom = _db.Queues.Count(x => x.Type_FK == 3 && x.SeriesID_FK == last.SereisID);
                    last.Clinker = _db.Queues.Count(x => x.Type_FK == 4 && x.SeriesID_FK == last.SereisID);
                    last.Member = (short)_db.Queues.Count(x => x.GroupCommission == 30 && x.SeriesID_FK == last.SereisID);
                    last.Native = (short)_db.Queues.Count(x => x.GroupCommission == 31 && x.SeriesID_FK == last.SereisID);
                    last.Other = (short)_db.Queues.Count(x => x.GroupCommission == 32 && x.SeriesID_FK == last.SereisID);
                    last.SeriesCount = _db.Queues.Count(x => x.SeriesID_FK == last.SereisID);
                    last.enabeled = false;
                    last.closing = true;
                    _db.SaveChanges();

                    var series = new SeriesPrice();
                    series.SeriesName = (int)last.SeriesName + 1;
                    series.SeriesDateStart = DateTime.Now;
                    series.userCreator = PublicVar.UserID;
                    series.enabeled = true;
                    series.closing = false;
                    _db.SeriesPrices.Add(series);
                    _db.SaveChanges();
                    ts.Commit();
                    return true;
                }
                catch
                {
                    ts.Rollback();
                    return false;
                }
            }
        }

        public async Task<SeriesPrice> LastSerial()
        {
            return await _db.SeriesPrices.SingleOrDefaultAsync(x => x.enabeled == true && x.closing == false);
        }

        public async Task<bool> LoadLastSerial()
        {
            var qry = await LastSerial();
            if (qry != null)
            {
                PublicVar.SeriesID = qry.SereisID;
                PublicVar.SeriesName = qry.SeriesName;
                PublicVar.DateSerial = qry.SeriesDateStart;
                return true;
            }
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
            return true;
        }

        public async Task<bool> ResetScheduleList()
        {
            try
            {
                for (byte i = 101; i < 108; i++)
                {
                    var qry = await _db.LoadTypes.FindAsync(i);
                    if (qry != null) qry.Type = "0";
                }
                await _db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<bool> CounterScheduleList()
        {
            try
            {
                for (byte i = 101; i < 108; i++)
                {
                    var qry = await _db.LoadTypes.FindAsync(i);
                    if (qry != null) qry.Type =
                          (await _db.Queues.CountAsync(x => x.Type_FK == i - 100 && x.Status_FK == 20)).ToString();
                }
                await _db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<string> GetScheduleByTypeId(byte typeId)
        {
            var scheduleByTypeId = await _db.LoadTypes.FindAsync(typeId + 100);
            if (scheduleByTypeId != null)
            {
                scheduleByTypeId.Type = (Convert.ToInt32(scheduleByTypeId.Type) + 1).ToString();
                await _db.SaveChangesAsync();
            }
            return scheduleByTypeId?.Type;
        }

        public int RetrunDirverID(string tag)
        {
            var result = _db.Drivers.SingleOrDefault(x => x.Tag == tag);
            return result?.DriverID ?? 0;
        }

        public async Task<List<Queue>> GetTamdid()
        {
            _db = new TruckersEntities();
            return await _db.Queues.Where(x => x.mandeh != true && x.Status_FK == 20).ToListAsync();
        }

        public async Task<bool> Tamdid(int queueId)
        {
            try
            {
                var result =await _db.Queues.FindAsync(queueId);
                result.mandeh = true;
                await _db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Change23to20(int driver)
        {

            if (!await _db.Queues.AnyAsync(x => x.Status_FK == 20))
            {
                var qryMax = await _db.Queues.MaxAsync(x => x.Status_FK == 23 && x.DriverID_FK == driver);
            }

        }


        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}
