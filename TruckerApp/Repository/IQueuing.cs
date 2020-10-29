using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckerApp.ViewModels;

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
        /// صدور نوبت جدید و مبلغ دریافتی صندوق
        /// </summary>
        /// <param name="viewModelQueue">موجودیت و اطلاعات نوبت</param>
        /// <param name="viewModelCash">موجودیت و اطلاهات صندوق دریافتی</param>
        /// <returns></returns>
        bool RegisterNewQueue(ViewModelQueue viewModelQueue, ViewModelCash viewModelCash);

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
    }
}
