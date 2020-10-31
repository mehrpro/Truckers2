using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using System.Data.Entity;
using System.Windows.Forms;
using TruckerApp.ExtentionMethod;
using TruckerApp.Repository;
using TruckerApp.ViewModels.Queueing;

namespace TruckerApp.UserForm
{
    public partial class FrmQueueList : Form
    {
        private readonly IQueuing _queuing;
        public FrmQueueList(IQueuing queuing)
        {
            _queuing = queuing;
            InitializeComponent();
            SerialList();
            cbxSerial.Properties.DisplayMember = "SeriesName";
            cbxSerial.Properties.ValueMember = "SereisID";
        }
        private async void SerialList()
        {
            cbxSerial.Properties.DataSource = await _queuing.GetSeriesList();
        }
        private async void txtSerial_EditValueChanged(object sender, EventArgs e)
        {
            var select = (ViewModelSeriesList)cbxSerial.GetSelectedDataRow();
            if (select != null)
            {
                txtDate.EditValue = select.SeriesDateStart;
                txtFalaeh.EditValue = await _queuing.TotalTypeByTypeId(1,select.SereisID);
                txtPacket.EditValue = await _queuing.TotalTypeByTypeId(2, select.SereisID);
                txtGandom.EditValue = await _queuing.TotalTypeByTypeId(3, select.SereisID);
                txtClinker.EditValue = await _queuing.TotalTypeByTypeId(4, select.SereisID);
                txtAhakfaleh.EditValue = await _queuing.TotalTypeByTypeId(5, select.SereisID);
                txtAhakPackat.EditValue = await _queuing.TotalTypeByTypeId(6, select.SereisID);
                txtOtherType.EditValue = await _queuing.TotalTypeByTypeId(7, select.SereisID);

                txtMember.EditValue = await _queuing.TotalGroupByGroupId(30, select.SereisID);
                txtNoMember.EditValue = await _queuing.TotalGroupByGroupId(31, select.SereisID);
                txtOther.EditValue = await _queuing.TotalGroupByGroupId(32, select.SereisID);

                gridControl1.DataSource = await _queuing.GetQueueListBySeriesId(select.SereisID);
            }
        }
    }
}
