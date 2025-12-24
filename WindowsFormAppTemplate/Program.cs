using DatabaseManager;
using WindowsFormAppTemplate.Configuration;
using WindowsFormAppTemplate.Forms;

namespace WindowsFormAppTemplate
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Database parameters (password should be encrypted...)
            string DatabaseServer = ConfigurationHandler.GetConfigurationValue("DatabaseServer");
            string DatabasePort = ConfigurationHandler.GetConfigurationValue("DatabasePort");
            string DatabaseName = ConfigurationHandler.GetConfigurationValue("DatabaseName");
            string DatabaseUser = ConfigurationHandler.GetConfigurationValue("DatabaseUser");
            string DatabasePassword = ConfigurationHandler.GetConfigurationValue("DatabasePassword");

            String connectionString = "Server=" + DatabaseServer + ";Port=" + DatabasePort + ";Database=" + DatabaseName + ";User=" + DatabaseUser + ";Password=" + DatabasePassword + ";";

            DatabaseHandler databaseManager = DatabaseHandler.GetInstance(connectionString);

            FormLogin frmLogin = new FormLogin();
            Application.Run(frmLogin);

            if (frmLogin.LoginSuccessful())
            {
                Application.Run(new FormMain());
            }
            else 
            {
                Application.Exit();
            }

            
        }
    }
}