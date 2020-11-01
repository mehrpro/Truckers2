using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckerApp.ExtentionMethod;
using TruckerApp.ViewModels;
using TruckerApp.ViewModels.Queueing;

namespace TruckerApp.Repository
{
    public interface IQueuing
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
        Task<int> TotalTypeByTypeId(byte typeId,int serieseId);
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
        Task<List<Queue>> GetQueueListBySeriesId(int serieseId);
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
        Task<bool> NewSerial();
        /// <summary>
        /// آخرین سریال فروش صادر شده
        /// </summary>
        /// <returns></returns>
        Task<SeriesPrice> LastSerial();

    }

    public class Queuing : IQueuing
    {
        private readonly TruckersEntities db;
        public Queuing(TruckersEntities db)
        {
            this.db = db;
        }
        public async Task<List<ViewModelCargoType>> GetAllCargoType()
        {
            var qryCargoType = await db.LoadTypes.Where(x => x.TypeID < 10).ToListAsync();
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
            var max = await db.Queues.Where(x => x.SeriesID_FK == PublicVar.SeriesID && x.Type_FK == typeId).ToListAsync();
            if (max.Count == 0) return 1;
            return max.Max(x => x.Number) + 1;
        }
        private async Task<Commission> GetCommissionByGroupId(byte groupId)
        {
            return await db.Commissions.SingleOrDefaultAsync(x => x.enabled && x.Groups_FK == groupId);
        }
        public async Task<Commission> GetCommisinoByTypeIdAndByGroupId(byte typeId, byte groupId)
        {
            if (groupId != 32)//بومی
            {
                if (groupId == 30)//عضو بومی
                {
                    if (typeId == 4)//کلینکر
                        return await GetCommissionByGroupId(13);
                    return await GetCommissionByGroupId(14);
                }

                if (groupId == 31)//غیر عضو بومی
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
            return db.Drivers.FirstOrDefault(x => x.Tag == resultEn);
        }
        public async Task<Queue> FindByQueue(string tag)
        {
            return await db.Queues.SingleOrDefaultAsync(x => x.Status_FK == 20 && x.Driver.Tag == tag);
        }

        public async Task<Queue> FindByQueue(int driverId)
        {
            return await db.Queues.SingleOrDefaultAsync(x => x.DriverID_FK == driverId && x.Status_FK == 20);
        }

        public bool RegisterNewQueue(ViewModelQueue viewModelQueue, ViewModelCash viewModelCash)
        {
            try
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    var newQueue = new Queue
                    {
                        Number = viewModelQueue.Number,
                        GroupCommission = viewModelQueue.GroupCommission,
                        Type_FK = viewModelQueue.TypeFk,
                        DateTimeRegister = viewModelQueue.DateTimeRegister,
                        DriverID_FK = viewModelQueue.DriverIdFk,
                        Status_FK = viewModelQueue.StatusFk,
                        ComosiunID_FK = viewModelQueue.ComosiunIdFk,
                        SeriesID_FK = viewModelQueue.SeriesIdFk,
                    };
                    db.Queues.Add(newQueue);
                    db.SaveChanges();
                    var newCash = new Cash
                    {
                        QueueID_FK = newQueue.ID,
                        Pos = Convert.ToInt32(viewModelCash.Pos),
                        CashDesk = Convert.ToInt32(viewModelCash.CashDesk),
                        userID = PublicVar.UserID,
                        seriesID_FK = newQueue.SeriesID_FK,
                    };
                    db.Cashes.Add(newCash);
                    db.SaveChanges();
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
            return await db.Queues.CountAsync(x => x.SeriesID_FK == serieseId && x.Type_FK == typeId);
        }

        public async Task<int> TotalGroupByGroupId(byte groupId, int serieseId)
        {
            return await db.Queues.CountAsync(x => x.SeriesID_FK == serieseId && x.GroupCommission == groupId);
        }

        public async Task<List<Queue>> GetQueueListBySeriesId(int serieseId)
        {
            return await db.Queues.Where(x => x.SeriesID_FK == serieseId).ToListAsync();
        }

        public async Task<List<ViewModelSeriesList>> GetSeriesList()
        {
            var qry= await db.SeriesPrices.ToListAsync();
            var list = new List<ViewModelSeriesList>();
            
            foreach (var seriesPrice in qry.OrderByDescending(x=>x.SereisID))
            {
                list.Add(new ViewModelSeriesList()
                {
                    
                    SereisID = seriesPrice.SereisID,
                    SeriesName = seriesPrice.SeriesName,
                    SeriesDateStart = seriesPrice.SeriesDateStart.PersianConvertor(),
                    SeriesCount = seriesPrice.SeriesCount,
                    SeriesDateEnd = seriesPrice.SeriesDateEnd == null ?"": seriesPrice.SeriesDateEnd.Value.PersianConvertor(),
                    userCreator = $@"{seriesPrice.User.FirstName} {seriesPrice.User.LastName}"
                });
            }
            return list;
        }

        public async Task<bool> RetrunCashByQueueID(int queueId,byte typeId)
        {
            using (var trans = db.Database.BeginTransaction())
            {
                try
                {
                    var qry = db.Cashes.Single(x => x.QueueID_FK == queueId);
                    var qryQueue = db.Queues.Single(x => x.ID == queueId);
                    qryQueue.Status_FK = typeId;
                    qry.Pos = qry.CashDesk = 0;
                    await db.SaveChangesAsync();
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
                var qryQueue = await db.Queues.SingleOrDefaultAsync(x => x.ID == queueId);
                if (qryQueue==null)
                    return false;
                qryQueue.Status_FK = 23;
                await db.SaveChangesAsync();
                return true;

            }
            catch 
            {
                return false;
            }
            
        }

        public async Task<bool> NewSerial()
        {
            try
            {
                using (var ts = db.Database.BeginTransaction())
                {
                    var last = db.SeriesPrices.Single(x => x.enabeled == true && x.closing == false);
                    if (db.Cashes.FirstOrDefault(x => x.seriesID_FK == last.SereisID) == null)
                    {
                        return false;
                    }
                    last.SeriesDateEnd = DateTime.Now;
                    last.Faleh = db.Queues.Count(x => x.Type_FK == 1 && x.SeriesID_FK == last.SereisID);
                    last.Packet = db.Queues.Count(x => x.Type_FK == 2 && x.SeriesID_FK == last.SereisID);
                    last.Gandom = db.Queues.Count(x => x.Type_FK == 3 && x.SeriesID_FK == last.SereisID);
                    last.Clinker = db.Queues.Count(x => x.Type_FK == 4 && x.SeriesID_FK == last.SereisID);
                    last.Member = (short) db.Queues.Count(x => x.GroupCommission == 30 && x.SeriesID_FK == last.SereisID);
                    last.Native = (short) db.Queues.Count(x => x.GroupCommission == 31 && x.SeriesID_FK == last.SereisID);
                    last.Other = (short) db.Queues.Count(x => x.GroupCommission == 32 && x.SeriesID_FK == last.SereisID);
                    last.SeriesCount =  db.Queues.Count(x => x.SeriesID_FK == last.SereisID);
                    last.enabeled = false;
                    last.closing = true;
                    db.SaveChanges();

                    var series = new SeriesPrice
                    {
                        SeriesName = last.SeriesName + 1,
                        SeriesDateStart = DateTime.Now,
                        userCreator = PublicVar.UserID,
                        enabeled = true,
                        closing = false
                    };
                    db.SeriesPrices.Add(series);
                    db.SaveChanges();
                    ts.Commit();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<SeriesPrice> LastSerial()
        {
            return await db.SeriesPrices.SingleOrDefaultAsync(x => x.enabeled ==true && x.closing == false);
        }
    }
}
