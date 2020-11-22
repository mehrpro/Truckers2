using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using TruckerApp.ExtentionMethod;
using TruckerApp.Repository;

namespace TruckerApp.UserForm
{
    public partial class FrmRevFish3333 : XtraForm
    {
        private readonly ICustomers _customers;
        private readonly IQueuing _queuing;
        public FrmRevFish3333(ICustomers customers, IQueuing queuing)
        {
            _customers = customers;
            _queuing = queuing;
            InitializeComponent();

        }
        private int _selectid;
        private string _name;
        private string _seriesNumber;
        private string _smartcart;
        private string _tagnumber;
        private string _memeber;
        private string _commission;
        private string _type;
        private string _code;
        private string _dateTime;


        // private Driver row;


        private async void cbxSmart_EditValueChanged(object sender, EventArgs e)
        {
            _selectid = 0;
            var row = (Driver)cbxSmart.GetSelectedDataRow();
            if (row == null)
            {
                txtName.EditValue =
                    txtNumber.EditValue =
                        txtTag.EditValue =
                            txtDateReg.EditValue =
                                txtType.EditValue =
                                    txtserial.EditValue = null;
                return;
            }
            _name = txtName.Text = $@"{row.FirstName}  {row.LastName}";
            _tagnumber = txtTag.Text = $@"{row.TagNumber}";
            _smartcart = row.SmartCart.ToString();
            _memeber = row.LoadType.Type.ToString();
            _code = row.driver_code.ToString();
      
            var lastQueue = await _queuing.FindByQueue(row.DriverID);
            if (lastQueue == null)
            {

                txtNumber.EditValue =
                        txtDateReg.EditValue =
                            txtType.EditValue =
                                txtserial.EditValue = null;
                return;
            }
            var com = await _queuing.GetCommisinoByTypeIdAndByGroupId(lastQueue.LoadType.TypeID, row.GroupID);
            _commission = com.CommissionPrice.ToString();
            _type = lastQueue.LoadType.Type.ToString();
            _selectid = lastQueue.ID;
            _dateTime = lastQueue.DateTimeRegister.PersianConvertorFull();
            _seriesNumber = $"س {lastQueue.SeriesPrice.SeriesName}  شماره {lastQueue.Number}";
            txtserial.EditValue = lastQueue.SeriesPrice.SeriesName;
            txtNumber.EditValue = lastQueue.Number;
            txtType.EditValue = lastQueue.LoadType.Type;
            txtDateReg.EditValue = lastQueue.DateTimeRegister.PersianConvertor();
        }

        private void PrintFish()
        {
            var report = XtraReport.FromFile("Report_Fish.repx", true);
            var tool = new ReportPrintTool(report);
            report.Parameters["date"].Value = _dateTime;
            report.Parameters["name"].Value = _name;
            report.Parameters["seriesNumber"].Value = _seriesNumber;
            report.Parameters["smartcart"].Value = _smartcart;
            report.Parameters["TagNumbers"].Value = _tagnumber;
            report.Parameters["member"].Value = _memeber;
            report.Parameters["price"].Value = _commission;
            report.Parameters["Type"].Value = _type;
            report.Parameters["code"].Value = _code;
            report.Parameters["number"].Value = "چاپ مجدد";
            tool.PrintDialog();
        }

        private  void btnRevSave_Click(object sender, EventArgs e)
        {
            //if (_selectid > 0)
            //{
            //    var result = await _queuing.Change23To20(_selectid);
            //    if (result)
            //    {
            //        XtraMessageBox.Show(PublicVar.SuccessfulSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        Close();
            //    }
            //    else
            //        XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK,
            //            MessageBoxIcon.Warning);
            //}

            PrintFish();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FrmRevFish_Load(object sender, EventArgs e)
        {
            cbxSmart.Properties.DataSource = await _customers.GetAllDriver();
            cbxSmart.Properties.DisplayMember = "SmartCart";
            cbxSmart.Properties.ValueMember = "ID";

        }


    }
}
