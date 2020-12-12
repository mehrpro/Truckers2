using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TruckerApp.Repository;

namespace TruckerApp.UserForm.Customer
{
    public partial class FrmMembershipList3 : XtraForm
    {
        private readonly ICustomers _customers;
        public FrmMembershipList3(ICustomers customers)
        {
            _customers = customers;
            InitializeComponent();
        }

        private async void FrmMembershipList3_Load(object sender, System.EventArgs e)
        {
            DriversList.DataSource = await _customers.GetAllDriverForComboBox();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Export(bool pdfValue)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                if (pdfValue)
                {
                    saveDialog.Filter = "Pdf File (.pdf)|*.pdf";

                }
                else
                {
                    saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx ";
                }

                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            DriversList.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            DriversList.ExportToXlsx(exportFilePath);
                            break;

                        case ".pdf":
                            DriversList.ExportToPdf(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnSaveToExcel_Click(object sender, System.EventArgs e)
        {
            Export(false);
            
        }

        private void btnSaveToPDF_Click(object sender, EventArgs e)
        {
            Export(true);
        }
    }
    
}
