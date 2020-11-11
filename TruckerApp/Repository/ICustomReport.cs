using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckerApp.ExtentionMethod;
using TruckerApp.ViewModels;
using TruckerApp.ViewModels.Customers;
using TruckerApp.ViewModels.Queueing;

namespace TruckerApp.Repository
{
    /// <summary>
    /// لیست های سفارشی
    /// </summary>
    public interface ICustomReport : IDisposable
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

        /// <summary>
        /// لیست دریافتی های صندوق براساس شناسه سریال فروش
        /// </summary>
        /// <param name="seriesId">شناسه سریال فروش</param>
        /// <returns></returns>
        Task<List<Cash>> GetCashListBySeriesId(int seriesId);
        /// <summary>
        /// گزارش دفتر کا مابین دو تاریخ
        /// </summary>
        /// <param name="startDateTime">تاریخ آغاز</param>
        /// <param name="finishDateTime">تاریخ پایان</param>
        /// <returns></returns>
        Task<List<ViewModelTotalCashList>> GetTotalReportByBetweenDate(DateTime startDateTime, DateTime finishDateTime);


        /// <summary>
        /// لیست قبض های صادر شده براساس راننده
        /// </summary>
        /// <param name="driverId">شناسه راننده</param>
        /// <returns></returns>
        Task<List<ViewModelCustomerBillByDriverId>> GetQueueReportByDriverId(int driverId);



    }
    /// <summary>
    /// لیست های سفارشی
    /// </summary>
    public class CustomReport : ICustomReport
    {
        private  TruckersEntities _db;

        public CustomReport(TruckersEntities db)
        {
            _db = db;
        }
        public async Task<List<ViewModelReportList>> GetAllReportListByType(byte typeId)
        {
            _db = new TruckersEntities();
            var queryAll = await _db.Queues.Where(x => x.Status_FK == 20 && x.Type_FK == typeId).ToListAsync();
            var listResult = new List<ViewModelReportList>();
            int con = 1;
            foreach (var item in queryAll)
            {
                var list = new ViewModelReportList();
                list.Counter = con++;
                list.Number = $"({item.SeriesPrice.SeriesName})-{item.Number}";
                list.Name = $"{item.Driver.FirstName} {item.Driver.LastName}";
                list.Tag = item.Driver.TagNumber;
                list.Typeid = item.LoadType.Type;
                list.Phone = item.Driver.PhoneNumber;
                list.mandeh = item.mandeh == true ? @"قابل تمدید" : " ";
                listResult.Add(list);
            }

            return listResult;
        }

        public async Task<List<ViewModelReportList>> GetLastSeriesReportListByType(byte typeId)
        {
            var queryAll = await _db.Queues.Where(x => x.Status_FK == 20 && x.Type_FK == typeId && x.SeriesID_FK == PublicVar.SeriesID).OrderBy(x => x.ID).ToListAsync();
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

        public async Task<List<ViewModelNumberList>> GetQueueStatus20ByTypeID(byte typrId)
        {
            var qry = await _db.Queues.Where(x => x.Status_FK == 20 && x.Type_FK == typrId).ToListAsync();
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
                foreach (var item in viewModelNumberLists) _db.Queues.Find(item.ID).Status_FK = 23;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Cash>> GetCashListBySeriesId(int seriesId)
        {
            return await _db.Cashes.Where(x => x.seriesID_FK == seriesId).ToListAsync();
        }

        public async Task<List<ViewModelTotalCashList>> GetTotalReportByBetweenDate(DateTime startDateTime, DateTime finishDateTime)
        {
            var start = startDateTime.Date;
            var end = finishDateTime.Date.AddDays(1);
            var qry = await _db.SeriesPrices.Where(x => x.SeriesDateStart >= start).ToListAsync();
            var qry2 = qry.Where(x => x.SeriesDateStart <= end).ToList();
            //txtTotalSerial.EditValue = qry2.Count.ToString();
            var seriesIdList = new int[qry2.Count];
            for (var i = 0; i < qry2.Count; i++) seriesIdList[i] = qry2[i].SereisID;

            var cashLists = new List<ViewModelTotalCashList>();
            foreach (var id in seriesIdList)
            {
                var masterList = new List<Queue>();
                var qry23 = await _db.Queues.Where(x => x.SeriesID_FK == id && x.Status_FK == 23).AsNoTracking().ToListAsync();
                var qry20 = await _db.Queues.Where(x => x.SeriesID_FK == id && x.Status_FK == 20).AsNoTracking().ToListAsync();
                masterList.AddRange(qry23);
                masterList.AddRange(qry20);


                var newModel = new ViewModelTotalCashList();
                newModel.DateTime = _db.SeriesPrices.Find(id).SeriesDateStart.PersianConvertor();
                newModel.TotalCash = (long)await _db.Cashes.Where(x => x.seriesID_FK == id).SumAsync(x => x.CashDesk);
                newModel.TotalPos = (long)await _db.Cashes.Where(x => x.seriesID_FK == id).SumAsync(x => x.Pos);
                newModel.faleh =  masterList.Count(x => x.Type_FK == 1);
                newModel.packat = masterList.Count(x => x.Type_FK == 2);
                newModel.gandom = masterList.Count(x => x.Type_FK == 3);
                newModel.clinker = masterList.Count(x => x.Type_FK == 4);
                newModel.AhakFaleh = masterList.Count(x => x.Type_FK == 5);
                newModel.AhakPackat = masterList.Count(x => x.Type_FK == 6);
                newModel.Othertype = masterList.Count(x => x.Type_FK == 7);
                newModel.SeriesName = _db.SeriesPrices.Find(id).SeriesName;
                cashLists.Add(newModel);
            }

            return cashLists;

        }

        public async Task<List<ViewModelCustomerBillByDriverId>> GetQueueReportByDriverId(int driverId)
        {
            var qry = await _db.Queues.Where(x => x.DriverID_FK == driverId).ToListAsync();
            var list = new List<ViewModelCustomerBillByDriverId>();
            foreach (var item in qry)
            {
                list.Add(new ViewModelCustomerBillByDriverId
                {
                    ID = item.ID,
                    SerialName = item.SeriesPrice.SeriesName,
                    Number = item.Number,
                    DateRegister = item.DateTimeRegister.PersianConvertor(),
                    Bill = item.LoadType1.Type,
                    TypeId = item.LoadType.Type
                });
            }

            var @descending = list.OrderByDescending(x => x.ID);
            return @descending.ToList();

        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}
