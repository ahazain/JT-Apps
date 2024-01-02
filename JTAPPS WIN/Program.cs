using HomepageUser;
using wisata2;
using JT_APPS__Final_Setting_;
using JTAPPS_WIN;
using Fitur_Homepage_admin_penginapan;
using Inap;
using Fitur_Profile_Account;
using History_Fix;

namespace DesktopApp
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
            Application.Run(new Formlogin());
        }
    }
}
