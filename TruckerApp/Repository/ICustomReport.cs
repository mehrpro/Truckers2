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
    /// <summary>
    /// لیست های سفارشی
    /// </summary>
    public interface ICustomReport
    {
        /// <summary>
        ///  لیست همه بارنامه های صادر شده بر اساس نوع بار
        /// </summary>
        /// <param name="typrId">شناسه بار</param>
        /// <returns></returns>
        Task<List<ViewModelReportList>> GetAllReportListByType(byte typeId);
        /// <summary>
        /// لیست بارنامه های صادره شده امروز براساس نوع بار
        /// </summary>
        /// <param name="typeId">شناسه نوع بار</param>
        /// <returns></returns>
        Task<List<ViewModelReportList>> GetLastSeriesReportListByType(byte typeId);
        /// <summary>
        /// تعداد حواله های مانده روز براساس نوع حواله
        /// </summary>
        /// <param name="typrId">شناسه نوع بار</param>
        /// <returns></returns>
        Task<int> CountOfStatus20_LastSeries(byte typeId);
        /// <summary>
        /// تعداد حواله های مانده بر اساس نوع حواله
        /// </summary>
        /// <param name="typeId">شناسه نوع بار</param>
        /// <returns></returns>
        Task<int> CountOfStatus20_All(byte typeId);
        /// <summary>
        /// تعداد حواله های باقی مانده روز های قبل
        /// </summary>
        /// <param name="typeId">شناسه نوع بار</param>
        /// <returns></returns>
        Task<int> CountOfStatus20_Old(byte typeId);
        /// <summary>
        /// لیست بارنامه های صادر شده برای فرم رسید 
        /// </summary>
        /// <param name="typrId">شناسه نوع بار</param>
        /// <returns></returns>
        Task<List<ViewModelNumberList>> GetQueueStatus20ByTypeID(byte typrId);

        /// <summary>
        /// ثبت و ذخیره نوبت های رسید شده
        /// </summary>
        /// <param name="viewModelNumberLists">لیست نوبت</param>
        /// <returns></returns>
        bool SaveAcceptListQueue23(List<ViewModelNumberList> viewModelNumberLists);
    }
    /// <summary>
    /// لیست های سفارشی
    /// </summary>
    public class CustomReport : ICustomReport
    {
        private readonly TruckersEntities db;

        public CustomReport(TruckersEntities db)
        {
            this.db = db;
        }
        public async Task<List<ViewModelReportList>> GetAllReportListByType(byte typeId)
        {
            var queryAll = await db.Queues.Where(x => x.Status_FK == 20 && x.Type_FK == typeId).OrderBy(x => x.ID).ToListAsync();
            var listResult = new List<ViewModelReportList>();
            int con = 1;
            foreach (var item in queryAll)
            {
                listResult.Add(new ViewModelReportList
                {
                    Counter = con++,
                    Number = $"({item.SeriesPrice.SeriesName})-{item.Number}",
                    Name = $"{item.Driver.FirstName} {item.Driver.LastName}",
                    Tag = item.Driver.Tag.PlateConvertToFarsi(),
                    Typeid = item.LoadType.Type,
                    Phone = item.Driver.PhoneNumber
                });
            }

            return listResult.OrderBy(x => x.Typeid).ToList();
        }

        public async Task<List<ViewModelReportList>> GetLastSeriesReportListByType(byte typeId)
        {
            var queryAll = await db.Queues.Where(x => x.Status_FK == 20 && x.Type_FK == typeId && x.SeriesID_FK == PublicVar.SeriesID).OrderBy(x => x.ID).ToListAsync();
            var listResult = new List<ViewModelReportList>();
            int con = 1;
            foreach (var item in queryAll)
            {
                listResult.Add(new ViewModelReportList
                {
                    Counter = con++,
                    Number = $"({item.SeriesPrice.SeriesName})-{item.Number}",
                    Name = $"{item.Driver.FirstName} {item.Driver.LastName}",
                    Tag = item.Driver.Tag.PlateConvertToFarsi(),
                    Typeid = item.LoadType.Type,
                    Phone = item.Driver.PhoneNumber
                });
            }

            return listResult.OrderBy(x => x.Typeid).ToList();
        }

        public async Task<int> CountOfStatus20_LastSeries(byte typeId)
        {
            return await db.Queues.CountAsync(x => x.Status_FK == 20 && x.Type_FK == typeId && x.SeriesID_FK == PublicVar.SeriesID);
        }

        public async Task<int> CountOfStatus20_All(byte typeId)
        {
            return await db.Queues.CountAsync(x => x.Status_FK == 20 && x.Type_FK == typeId);
        }

        public async Task<int> CountOfStatus20_Old(byte typeId)
        {
            return await db.Queues.CountAsync(x => x.Status_FK == 20 && x.Type_FK == typeId && x.SeriesID_FK != PublicVar.SeriesID);
        }

        public async Task<List<ViewModelNumberList>> GetQueueStatus20ByTypeID(byte typrId)
        {
            var qry = await db.Queues.Where(x => x.Status_FK == 20 && x.Type_FK == typrId).ToListAsync();
            var list = new List<ViewModelNumberList>();
            if (qry.Count > 0)
            {
                foreach (var itemQueue in qry)
                {
                    var id = itemQueue.ID;
                    var name = $"{itemQueue.Driver.FirstName} {itemQueue.Driver.LastName}";
                    var tag = $"{itemQueue.Driver.TagNumber}";
                    var date = itemQueue.DateTimeRegister;
                    list.Add(new ViewModelNumberList()
                    {
                        ID = id,
                        Serial = itemQueue.SeriesPrice.SeriesName,
                        Number = itemQueue.Number,
                        Name = name,
                        Tag = tag,
                        Date = date

                    });
                }

            }
            return list;
        }

        public bool SaveAcceptListQueue23(List<ViewModelNumberList> viewModelNumberLists)
        {
            try
            {
                foreach (var item in viewModelNumberLists) db.Queues.Find(item.ID).Status_FK = 23;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
