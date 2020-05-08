using System;
using System.Collections.Generic;

using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TruckerApp.UserForm
{
    public partial class FrmSerial : XtraForm
    {
        public FrmSerial()
        {
            InitializeComponent();
            grid();
        }

        private Counter Counter1 { get; } = new Counter();
        private void grid()
        {
            seriesBindingSource.DataSource = _serList = db.SeriesPrices.ToList();
        }

        private TruckersEntities db = new TruckersEntities();
        private int serialNumber;
        private List<SeriesPrice> _serList;
        private void SetupPage()
        {
            txtDate.Text = DateTime.Today.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
            var userCreator = db.Users.SingleOrDefault(x => x.userID == PublicVar.UserID);
            txtUsers.Text = $"{userCreator.FirstName} {userCreator.LastName}";
            txtLastSerial.Text = PublicVar.SeriesName.ToString();
        }

        private void FrmSerial_Load(object sender, EventArgs e)
        {
            SetupPage();
        }


        private void btnNewSerial_Click(object sender, EventArgs e)
        {
          
            try
            {
                using (var ts = db.Database.BeginTransaction())
                {
                    var last = db.SeriesPrices.Single(x => x.enabeled == true && x.closing == false);
                    if(db.Cashes.FirstOrDefault(x => x.seriesID_FK == last.SereisID) == null) return;
                    last.SeriesDateEnd = DateTime.Now;
                    last.Faleh = Counter1.faleh(last.SereisID);
                    last.Packet = Counter1.packet(last.SereisID);
                    last.Gandom = Counter1.gandom(last.SereisID);
                    last.Clinker = Counter1.clinker(last.SereisID);
                    last.Member = Counter1.member(last.SereisID);
                    last.Native = Counter1.noMember(last.SereisID);
                    last.Other = Counter1.other(last.SereisID);
                    last.SeriesCount = Counter1.SeriesCount(last.SereisID);
                    last.enabeled = false;
                    last.closing = true;
                    db.SaveChanges();

                    var series = new SeriesPrice();
                    series.SeriesName = last.SeriesName + 1;// Counter1.LastSeriesNum() + 1;
                    series.SeriesDateStart = DateTime.Now;
                    series.userCreator = PublicVar.UserID;
                    series.enabeled = true;
                    series.closing = false;
                    db.SeriesPrices.Add(series);
                    db.SaveChanges();
                    ts.Commit();
                    var Msg = $"سریال فروش {series.SeriesName} در تاریخ {series.SeriesDateStart} ایجاد شد ";
                    XtraMessageBox.Show(Msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Task.Run(() => emailSender(last.SereisID));
                    Counter1.serialBuy();
                    grid();
                    SetupPage();
                }
            }
            catch
            {
                XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emailSender(int id)
        {
            var db = new TruckersEntities();
            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();
            var qry = db.SeriesPrices.Single(x => x.SereisID == id);
            var cashSum =db.Cashes.Where(x => x.seriesID_FK == id).Sum(x => x.CashDesk.Value);
            var posSum = db.Cashes.Where(x => x.seriesID_FK == id).Sum(x => x.Pos.Value);
            var qry10 = db.Queues.Count(x => x.SeriesID_FK == id && x.Status_FK == 10).ToString(); //==null?0: db.Queues.Count(x => x.SeriesID_FK == id && x.Status_FK == 10);
            var qry11 = db.Queues.Count(x => x.SeriesID_FK == id && x.Status_FK == 11).ToString(); // == null? 0: db.Queues.Count(x => x.SeriesID_FK == id && x.Status_FK == 11);
            var qry12 = db.Queues.Count(x => x.SeriesID_FK == id && x.Status_FK == 12).ToString(); // == null? 0: db.Queues.Count(x => x.SeriesID_FK == id && x.Status_FK == 12);
            var qry23 = db.Queues.Count(x => x.SeriesID_FK == id && x.Status_FK == 23).ToString(); // == null? 0 : db.Queues.Count(x => x.SeriesID_FK == id && x.Status_FK == 23);
            var qry20 = db.Queues.Count(x => x.SeriesID_FK == id && x.Status_FK == 20).ToString(); // == null ? 0:db.Queues.Count(x => x.SeriesID_FK == id && x.Status_FK == 20); 

            var subject = $"گزارش فروش روزانه اتوماسیون پایانه {persianCalendar.GetYear(qry.SeriesDateStart)}/{persianCalendar.GetMonth(qry.SeriesDateStart)}/{persianCalendar.GetDayOfMonth(qry.SeriesDateStart)} سریال فروش {qry.SeriesName}";
            var body = $"صورت وضعیت سریال فروش{qry.SeriesName} \r\n" +
                      $"******************************* \r\n" +
                      $"تعداد {qry.Faleh} حواله فله صادر شد  \r\n" +
                      $"تعداد {qry.Packet} حواله پاکت صادر شد \r\n" +
                      $"تعداد {qry.Gandom} حواله غلات صادر شد \r\n" +
                      $"تعداد {qry.Clinker} حواله کلینکر صادر شد \r\n" +
                      $"مجموع تعدادی حواله های صادر شده {qry.SeriesCount} \r\n" +
                      $"******************************* \r\n"+
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
                      $" سیستم اتوماسیون پایانه تاریخ  {persianCalendar.GetYear(qry.SeriesDateStart)}/{persianCalendar.GetMonth(qry.SeriesDateStart)}/{persianCalendar.GetDayOfMonth(qry.SeriesDateStart)} \r\n";
            var fromAddress = new MailAddress("automation.sepehr@gmail.com", $"صورت وضعیت سریال فروش{qry.SeriesName}");
            var toAddress = new MailAddress("bijarpayaneh@gmail.com", "گزارش فروش روزانه اتوماسیون پایانه");
            const string fromPassword = "Ss987654";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };


            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,

            })
            {
                smtp.Send(message);
            }
        }
    }
}
