using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.ViewModels;

namespace TruckerApp.UserForm.cash
{
    public partial class FrmCash : XtraForm
    {
        public ViewModelCash ModelCash;
        public string CashTemp { get; set; }
        public FrmCash()
        {
            InitializeComponent();
            ModelCash = new ViewModelCash();
            txtPOS.Text = CashTemp;

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ModelCash.Pos = Convert.ToInt32(txtPOS.EditValue);
            ModelCash.CashDesk = Convert.ToInt32(txtCash.EditValue);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
