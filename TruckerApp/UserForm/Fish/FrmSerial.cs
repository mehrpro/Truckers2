using System;
using System.Collections.Generic;

using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.ExtentionMethod;
using TruckerApp.Repository;

namespace TruckerApp.UserForm.Fish
{
    public partial class FrmSerial : XtraForm
    {
        private readonly ICounter _counter;
        private readonly IQueuing _queuing;
        private readonly IReportSender _reportSender;
        public FrmSerial(ICounter counter, IQueuing queuing, IReportSender reportSender)
        {
            _counter = counter;
            _queuing = queuing;
            _reportSender = reportSender;
            InitializeComponent();

        }


        private async void Grid()
        {
            gridControl1.DataSource = await _queuing.GetSeriesList();
        }

        private void SetupPage()
        {
            txtDate.EditValue = DateTime.Today.PersianConvertor();
            txtTime.EditValue = DateTime.Now.ToLongTimeString();
            txtUsers.EditValue = PublicVar.OpreatorName;
            txtLastSerial.EditValue = PublicVar.SeriesName;
        }

        private void FrmSerial_Load(object sender, EventArgs e)
        {
            Grid();
            SetupPage();
        }


        private async void btnNewSerial_Click(object sender, EventArgs e)
        {
            var result = await _queuing.NewSerial();
            if (result)
            {
                var series = await _queuing.LastSerial();
                if (series == null)
                {
                    _counter.serialBuy();
                    return;
                }
                var msg = $"سریال فروش {series.SeriesName} در تاریخ {series.SeriesDateStart} ایجاد شد ";
                XtraMessageBox.Show(msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                 var resultEmailSenderTask = await _reportSender.EmailSenderTask(series.SereisID);  
                 if (!resultEmailSenderTask)
                 {
                     //Send Message For Adminstrator
                 }
                _counter.serialBuy();
                Grid();
                SetupPage();
            }
            else
            {
                XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
