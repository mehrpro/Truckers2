using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.ExtentionMethod;
using TruckerApp.Repository;

namespace TruckerApp.UserForm.Fish
{
    public partial class FrmSerial : XtraForm
    {
      
        private readonly IQueuing _queuing;
        private readonly IReportSender _reportSender;
        public FrmSerial(IQueuing queuing, IReportSender reportSender)
        {
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
            var series = await _queuing.LastSerial();
            if (series == null)
            {
                return;
            }
            var result =  _queuing.NewSerial();
            await _queuing.LoadLastSerial();
            if (result)
            {
                var last = await _queuing.LastSerial();
                var msg = $"سریال فروش {last.SeriesName} در تاریخ {last.SeriesDateStart} ایجاد شد ";
                XtraMessageBox.Show(msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                var resultEmailSenderTask = await _reportSender.EmailSenderTask(series.SereisID);
                await _queuing.ResetScheduleList();

                if (!resultEmailSenderTask)
                {
                    //Send Message For Adminstrator
                    Logger.WriteMessageLog("NotSend Email");
                }
                Grid();
                SetupPage();
            }
            else
                XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
