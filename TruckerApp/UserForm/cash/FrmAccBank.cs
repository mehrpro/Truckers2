using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.Repository;

namespace TruckerApp.UserForm.cash
{
    public partial class FrmAccBank : XtraForm
    {

        private BankAccNum _accNumber;
        private BankAccNum AccNumber
        {
            get
            {
                _accNumber.BankName = txtBankName.Text;
                _accNumber.AccCart = txtAccCart.Text;
                _accNumber.FullName = txtFullNAme.Text;
                _accNumber.AccISBN = txtISBN.Text;
                _accNumber.AccNumber = txtAccNumber.Text;
                _accNumber.Editor = PublicVar.OpreatorName;
                return _accNumber;
            }
            set
            {
                _accNumber = value;
                txtBankName.Text = _accNumber.BankName;
                txtAccCart.Text = _accNumber.AccCart;
                txtFullNAme.Text = _accNumber.FullName;
                txtISBN.Text = _accNumber.AccISBN;
                txtAccNumber.Text = _accNumber.AccNumber;

            }
        }


        //private ViewModelBankAccNumber _accNumber;
        private IAdministrator _administrator;
        public FrmAccBank(IAdministrator administrator)
        {
            _administrator = administrator;
            _accNumber = new BankAccNum();
            InitializeComponent();
            GridRefreshData();
        }


        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            AccNumber = new BankAccNum();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID") != null)
            {
                var focusedRow = gridView1.GetFocusedRow();
                _accNumber = new BankAccNum();
                AccNumber = (BankAccNum)focusedRow;
                // AccNumber = _accNumber;

            }
        }

        private async void GridRefreshData()
        {
            gridControl1.DataSource = await _administrator.GatAllBankNumber();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
            {
                XtraMessageBox.Show(PublicVar.NotComplateForm, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (AccNumber.ID > 0)
                {
                    var result = await _administrator.EditBankAccNumber(_accNumber);
                    if (result)
                    {
                        XtraMessageBox.Show(PublicVar.SuccessfulSave, Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        AccNumber = new BankAccNum();
                    }
                    else
                    {
                        XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var result = await _administrator.AddNewBankAccNumber(_accNumber);
                    if (result)
                    {
                        XtraMessageBox.Show(PublicVar.SuccessfulSave, Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        AccNumber = new BankAccNum();
                    }
                    else
                    {
                        XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            GridRefreshData();
        }
    }
}
