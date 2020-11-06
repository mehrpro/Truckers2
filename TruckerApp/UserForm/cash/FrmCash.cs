using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.ViewModels;

namespace TruckerApp.UserForm.cash
{
    public partial class FrmCash : XtraForm
    {
        public ViewModelCash ModelCash;
        //public string CashTemp { get; set; }
        public FrmCash()
        {
            InitializeComponent();
            ModelCash = new ViewModelCash();
            txtPOS.Text = PublicVar.TempCash.ToString();

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ModelCash.Pos = Convert.ToInt32(txtPOS.EditValue);
            ModelCash.CashDesk = Convert.ToInt32(txtCash.EditValue);
            if (ModelCash.Pos + ModelCash.CashDesk == PublicVar.TempCash)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                XtraMessageBox.Show("مقادیر درست وارد نشده است لطفا مجدداً بررسی نمائید", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
   
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
