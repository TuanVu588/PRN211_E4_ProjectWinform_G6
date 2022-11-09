using PRN211_E4_ProjectWinform_G6.GUI;

namespace PRN211_E4_ProjectWinform_G6
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
            Application.Run(new MainGUI());
        }
    }
}