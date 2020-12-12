using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils.Extensions;
using DevExpress.XtraRichEdit.Fields;
using TruckerApp.ExtentionMethod;

namespace TruckerApp.Repository
{
    public interface IReportSender : IDisposable
    {
        /// <summary>
        /// ساخت گزارش ارسالی برای ایمیل
        /// </summary>
        /// <param name="lastSeriesId">شناسه آخرین سریال فروش</param>
        /// <returns></returns>
        Task<string[]> CreateMsgForEmail(int lastSeriesId);

        /// <summary>
        /// ارسال گزارشات به ایمیل
        /// </summary>
        /// <param name="lastSeriesId">شناسه آخرین سریال فروش بسته شده</param>
        /// <returns></returns>
        Task<bool> EmailSenderTask(int lastSeriesId);

        /// <summary>
        /// ارسال گزارش به ایمیل سریع
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        Task<bool> SendReportToEmail(string[] stream);
    }

    public class ReportSender : IReportSender
    {
        private TruckersEntities _db;

        public ReportSender(TruckersEntities db)
        {
            _db = db;
        }



        public async Task<string[]> CreateMsgForEmail(int lastSeriesId)
        {

            var result = new string[2];
            //result[0] = Subject
            //result[1] = body
            var qry = _db.SeriesPrices.Single(x => x.SereisID == lastSeriesId);
            var cashSum = await _db.Cashes.Where(x => x.seriesID_FK == lastSeriesId).SumAsync(x => x.CashDesk.Value);
            var posSum = await _db.Cashes.Where(x => x.seriesID_FK == lastSeriesId).SumAsync(x => x.Pos.Value);
            var qryAhakFaleh = await _db.Queues.CountAsync(x => x.SeriesID_FK == lastSeriesId && x.Type_FK == 5);
            var qryAhakPackat = await _db.Queues.CountAsync(x => x.SeriesID_FK == lastSeriesId && x.Type_FK == 6);
            var qryother = await _db.Queues.CountAsync(x => x.SeriesID_FK == lastSeriesId && x.Type_FK == 7);

            var qry10 = await _db.Queues.CountAsync(x => x.SeriesID_FK == lastSeriesId && x.Status_FK == 10);
            var qry11 = await _db.Queues.CountAsync(x => x.SeriesID_FK == lastSeriesId && x.Status_FK == 11);
            var qry12 = await _db.Queues.CountAsync(x => x.SeriesID_FK == lastSeriesId && x.Status_FK == 12);
            var qry23 = await _db.Queues.CountAsync(x => x.SeriesID_FK == lastSeriesId && x.Status_FK == 23);
            var qry20 = await _db.Queues.CountAsync(x => x.SeriesID_FK == lastSeriesId && x.Status_FK == 20);

            result[0] = $"گزارش فروش روزانه اتوماسیون پایانه {qry.SeriesDateStart.PersianConvertor()} سریال فروش {qry.SeriesName}";
            result[1] = $"صورت وضعیت سریال فروش{qry.SeriesName} \r\n" +
                      $"******************************* \r\n" +
                      $"تعداد {qry.Faleh} حواله فله صادر شد  \r\n" +
                      $"تعداد {qry.Packet} حواله پاکت صادر شد \r\n" +
                      $"تعداد {qry.Gandom} حواله غلات صادر شد \r\n" +
                      $"تعداد {qry.Clinker} حواله کلینکر صادر شد \r\n" +
                      $"تعداد {qryAhakFaleh} حواله آهک فله صادر شد \r\n" +
                      $"تعداد {qryAhakPackat} حواله آهک پاکت صادر شد \r\n" +
                      $"تعداد {qryother} حواله متفرقه صادر شد \r\n" +
                      $"مجموع تعدادی حواله های صادر شده {qry.SeriesCount} \r\n" +
                      $"******************************* \r\n" +
                      $"تعداد{qry10} حواله بدلیل خطای صدور باطل شده است  \r\n" +
                      $"تعداد{qry11} حواله تغییر محموله داده شد  \r\n" +
                      $"تعداد{qry12} حواله باطل و وجه بازگشت داده شد  \r\n" +
                      $"******************************* \r\n" +
                      $"تعداد{qry.Member} حواله برای رانندگان عضو صنف صادر شد \r\n" +
                      $"تعداد{qry.Native} حواله برای رانندگان بومی صادر شد \r\n" +
                      $"تعداد{qry.Other} حواله برای رانندگان غیربومی صادر شد \r\n" +
                      $"******************************* \r\n" +
                      $"جمع دریافت وجه نقدی {cashSum}  تومان می باشد  \r\n" +
                      $" جمع دریافت دستگاه کارت خوان {posSum} تومان می باشد   \r\n" +
                      $"جمع فروش{posSum + cashSum} تومان می باشد   \r\n" +
                      $"******************************* \r\n" +
                      $"تعداد{qry23} حواله رسید شدند \r\n" +
                      $"تعداد{qry20} حواله منتقل به سریال بعدی شدند \r\n" +
                      $"******************************* \r\n" +
                      $" سیستم اتوماسیون پایانه تاریخ  {qry.SeriesDateStart.PersianConvertor()} \r\n";
            return result;

        }

        public async Task<bool> EmailSenderTask(int lastSeriesId)
        {

            try
            {
                var resultMessage = await CreateMsgForEmail(lastSeriesId);
                var subject = resultMessage[0];
                var body = resultMessage[1];
                var qry = await _db.SeriesPrices.FindAsync(lastSeriesId);
                const string from = @"automation.sepehr@gmail.com";
                var fromDisplayName = $"صورت وضعیت سریال فروش{qry.SeriesName}";
                const string to = @"bijarpayaneh@gmail.com";
                var toDisplayName = @"گزارش فروش روزانه اتوماسیون پایانه";
                const string fromPassword = "Ss987654";

                var fromAddress = new MailAddress(from, fromDisplayName);
                var toAddress = new MailAddress(to, toDisplayName);

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };


                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body, })
                {
                    smtp.Send(message);

                }
                return true;
            }
            catch (Exception e)
            {
                var str = e.Message;
                return false;
            }

        }

        public async Task<bool> SendReportToEmail(string[] stream)
        {

            ContentType contentType = new ContentType
            {
                MediaType = MediaTypeNames.Application.Pdf,
                Name = $"{DateTime.Now.PersianConvertorFull()}-Bijar.pdf",

            };
            try
            {
                var typeid = Convert.ToByte(stream[1]);
               // var typeString = _db.LoadTypes.Single(x => x.TypeID == typeid).Type.ToString();
               var typeString = @"غلات";
                var subject = $"گزارش لیست نوبت {typeString} ";
                var body = @"این گزارش توسط اتوماسیون پایانه انجمن رانندگان شهرستان بیجار برای شما ارسال شده است";
                
                const string from = @"automation.sepehr@gmail.com";
                var fromDisplayName = @"اتوماسیون پایانه";
                const string to = @"ramin.kh60@gmail.com";
                var toDisplayName = $"ارسال گزارش {typeString} ";
                const string fromPassword = "Ss987654@";

                var fromAddress = new MailAddress(from, fromDisplayName);
                var toAddress = new MailAddress(to, toDisplayName);

                var smtp = new SmtpClient
                {
                    
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),

                };


                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body, 
                    Attachments = { new Attachment(stream[0],contentType)}
                })
                {
                    smtp.Send(message);

                }
                return true;
            }
            catch (Exception e)
            {
                var str = e.Message;
                return false;
            }
        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}
