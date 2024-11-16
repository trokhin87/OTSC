using Microsoft.VisualBasic.ApplicationServices;
using OTSC.DataBase;

namespace OTSC
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
            DataReader data = new DataReader("C:/Users/trokh/source/repos/OTSC/OTSC/DataBase/ConfigData.json");
            var form = new LoginPage.LoginView.LoginPage();
            var presenter = new LoginPage.LoginPresenter.LoginPresenter(form, data, @"C:\Users\trokh\source\repos\OTSC\OTSC\DataBase\ConfigData.json");
            Application.Run(form);
        }
    }
}