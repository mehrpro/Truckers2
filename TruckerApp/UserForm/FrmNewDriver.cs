﻿using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TruckerApp.UserForm
{
    public partial class FrmNewDriver : XtraForm
    {
        public FrmNewDriver()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                int smartcart =  Convert.ToInt32(txtSmartCart.Text);

                using (var db = new TruckersEntities())
                {
                    try
                    {
                        var newDriver = new Driver();
                        newDriver.FirstName = txtFirstName.Text.Trim();
                        newDriver.LastName = txtLastNAme.Text.Trim();
                        newDriver.PhoneNumber = txtPhoneNumber.Text.Trim();
                        newDriver.userID_FK = PublicVar.UserID;
                        newDriver.Tag = Convert.ToByte(txtTag.Text);
                        newDriver.TagNumber = txtTagNumber.Text;
                        newDriver.SmartCart = smartcart;
                        newDriver.Commission_Group = Convert.ToByte(radComosiun.EditValue);
                        newDriver.Membership = Convert.ToBoolean(chkMembership.EditValue);
                        newDriver.Native = Convert.ToBoolean(chkNative.EditValue);
                        db.Drivers.Add(newDriver);
                        var result = db.SaveChanges();
                        XtraMessageBox.Show(PublicVar.SuccessfulSave,
                            Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    catch
                    {
                        var qry = db.Drivers.SingleOrDefault(x => x.SmartCart == smartcart);
                        if (qry != null)
                        {
                            var tel = (Driver) qry;
                            string varString = $"شماره هوشمند {qry.SmartCart} به نام {qry.FirstName} {qry.LastName} قبلا ثبت شده است";
                            XtraMessageBox.Show(varString,
                                "خطایی کاربری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, 
                            Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {
                XtraMessageBox.Show(PublicVar.NotComplateForm, this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            txtSmartCart.Text = txtFirstName.Text =
                txtLastNAme.Text = txtPhoneNumber.Text = txtTag.Text = txtTagNumber.Text = "";

        }

        private void chkMembership_EditValueChanged(object sender, EventArgs e)
        {
            ComosionLevel();
        }

        private void ComosionLevel()
        {
            bool Mem, Nat;
            Mem = Convert.ToBoolean(chkMembership.EditValue);
            Nat = Convert.ToBoolean(chkNative.EditValue);
            if (Mem && Nat)
            {
                radComosiun.SelectedIndex = 0;
            }
            else if (!Mem && Nat)
            {
                radComosiun.SelectedIndex = 1;
            }
            else if(!Mem && !Nat)
            {
                radComosiun.SelectedIndex = 2;
            }
            else if (Mem && !Nat)
            {
                radComosiun.SelectedIndex =0 ;
            }
        }

        private void chkNative_EditValueChanged(object sender, EventArgs e)
        {
            ComosionLevel();
        }
    }
}