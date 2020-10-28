using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckerApp.ExtentionMethod;
using TruckerApp.ViewModels;

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
        Task<List<ReportList>> GetAllReportListByType(byte typeId);
        /// <summary>
        /// لیست بارنامه های صادره شده امروز براساس نوع بار
        /// </summary>
        /// <param name="typeId">شناسه نوع بار</param>
        /// <returns></returns>
        Task<List<ReportList>> GetLastSeriesReportListByType(byte typeId);
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
    }
    /// <summary>
    /// لیست های سفارشی
    /// </summary>
    public class CustomReport : ICustomReport
    {
        private readonly TruckersEntities _db;

        public CustomReport(TruckersEntities db)
        {
            this._db = db;
        }
        public async Task<List<ReportList>> GetAllReportListByType(byte typeId)
        {
            var queryAll = await _db.Queues.Where(x => x.Status_FK == 20 && x.Type_FK == typeId).OrderBy(x => x.ID).ToListAsync();
            var listResult = new List<ReportList>();
            int con = 1;
            foreach (var item in queryAll)
            {
                listResult.Add(new ReportList
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

        public async Task<List<ReportList>> GetLastSeriesReportListByType(byte typeId)
        {
            var queryAll = await _db.Queues.Where(x => x.Status_FK == 20 && x.Type_FK == typeId && x.SeriesID_FK == PublicVar.SeriesID).OrderBy(x => x.ID).ToListAsync();
            var listResult = new List<ReportList>();
            int con = 1;
            foreach (var item in queryAll)
            {
                listResult.Add(new ReportList
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
            return await _db.Queues.CountAsync(x => x.Status_FK == 20 && x.Type_FK == typeId && x.SeriesID_FK == PublicVar.SeriesID);
        }

        public async Task<int> CountOfStatus20_All(byte typeId)
        {
            return await _db.Queues.CountAsync(x => x.Status_FK == 20 && x.Type_FK == typeId);
        }

        public async Task<int> CountOfStatus20_Old(byte typeId)
        {
            return await _db.Queues.CountAsync(x => x.Status_FK == 20 && x.Type_FK == typeId && x.SeriesID_FK != PublicVar.SeriesID);
        }
    }
}
