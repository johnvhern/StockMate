using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace StockMate
{
    internal static class Program
    { 
        [STAThread]
        static void Main()
        {
            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("secrets.json", optional: true)
            .AddUserSecrets(Assembly.GetExecutingAssembly())
            .Build();

            string secretValue = config["SyncfusionLicense"];

            ApplicationConfiguration.Initialize();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(secretValue);
            Application.Run(new Forms.Login.frmLogin());
        }
    }
}