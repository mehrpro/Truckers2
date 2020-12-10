using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TruckerApp
{
    public static class PublicMessage
    {
        public static void SuccessSendEmail()
        {
            XtraMessageBox.Show(@"ایمیل با موفقیت ارسال شد", @"اتوماسیون پایانه", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void UnSuccessSendEmail()
        {
            XtraMessageBox.Show(@"ایمیل ارسال نشد", @"اتوماسیون پایانه", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
