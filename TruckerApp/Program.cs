using System;
using System.Configuration;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Linq;
using TruckerApp.ExtentionMethod;
using StructureMap;

namespace TruckerApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        static void Main(string[] args)
        {
            if (args != null && args.Contains("encrypt-config"))
            {
                if (args.Length < 2 || args[1] != "708801298") return;
                var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                var connectionStringSection = config.GetSection("connectionStrings") as ConnectionStringsSection;
                if (connectionStringSection != null && !connectionStringSection.SectionInformation.IsProtected)
                {
                    connectionStringSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }
                config.Save();
                return;
            }
            if (args != null && args.Contains("decrypt-config"))
            {
                if (args.Length < 2 || args[1] != "708801298") return;
                var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                var connectionStringSection = config.GetSection("connectionStrings") as ConnectionStringsSection;
                if (connectionStringSection != null && connectionStringSection.SectionInformation.IsProtected)
                {
                    connectionStringSection.SectionInformation.UnprotectSection();
                }
                config.Save();
                return;
            }
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainContainer = new Container(new TypeRegistery());
            var frmLogin = mainContainer.GetInstance<FrmLogin>();
            Application.Run(frmLogin);
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                var frmMain = mainContainer.GetInstance<FrmMain>();
                frmMain.ShowDialog();
            }
            else
                Environment.Exit(0);


        }
    }
}
