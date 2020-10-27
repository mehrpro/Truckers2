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
            //BonusSkins.Register();
            //SkinManager.EnableFormSkins();
            //UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");   // Whiteprint Blueprint Darkroom Metropolis  Visual Studio 2013 Light DevExpress Style
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //SkinManager.EnableFormSkins();
            //BonusSkins.Register();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
            if (PublicVar.Accsept)
            {
                FrmMain frm = new FrmMain();
                frm.ShowDialog();
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}
