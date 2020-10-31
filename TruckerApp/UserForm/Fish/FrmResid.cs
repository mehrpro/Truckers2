using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.Repository;
using TruckerApp.ViewModels.Queueing;

namespace TruckerApp.UserForm.Fish
{
    public partial class FrmResid : XtraForm
    {
        private readonly ICustomReport _report;
        private List<ViewModelNumberList> _dsAccept;
        private List<ViewModelNumberList> _dsList;

        public FrmResid(ICustomReport report)
        {
            _report = report;
            InitializeComponent();
            Clear();
            
        }

        private void Clear()
        {
            _dsAccept = new List<ViewModelNumberList>();
            _dsList = new List<ViewModelNumberList>();
            gridControlTop.DataSource = _dsList;
            gridControlBotten.DataSource = _dsAccept;

        }
        private async void ListResied(byte typeId)
        {
            Clear();
            gridControlTop.DataSource = _dsList = await _report.GetQueueStatus20ByTypeID(typeId);
            gridControlBotten.DataSource = _dsAccept.ToList();
        }

        private void btnDeleteRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("Serial") != null)
            {
                var sel = gridView1.GetFocusedRow();
                var id = (ViewModelNumberList) sel;
                _dsList.Remove(id);
                _dsAccept.Add(id);
                gridControlTop.DataSource = _dsList.ToList();
                gridControlBotten.DataSource = _dsAccept.ToList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ListResied(1);
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridView2.GetFocusedRowCellValue("Serial") == null)return;
            var sel = gridView2.GetFocusedRow();
            var id = (ViewModelNumberList)sel;
            _dsAccept.Remove(id);
            _dsList.Add(id);
            gridControlTop.DataSource = _dsList.ToList();
            gridControlBotten.DataSource = _dsAccept.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_dsAccept.Count<1)return;
            
            var result = _report.SaveAcceptListQueue23(_dsAccept);
            if (result)
            {
                XtraMessageBox.Show("ثبت شد", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
              Clear();
            }
            else
                XtraMessageBox.Show("ذخیره نشد مجدد تلاش کنید", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ListResied(2);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ListResied(3);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ListResied(4);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            ListResied(5);

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            ListResied(6);

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            ListResied(7);

        }
    }
}
