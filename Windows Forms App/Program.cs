using DAL.Repo.Config;

namespace Windows_Forms_App
{
    internal static class Program
    {

        private const string PATH = @"../../../../DAL/Repo/Config/Config.txt";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if(File.Exists(PATH))
            {
                if(Config.getLanguage().Equals("CROATIAN"))
                {
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("hr");
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hr");
                }
                Application.Run(new Favorite_National_Team());
            }
            else
            {
                Application.Run(new Initial_settings());
            }
        }
    }
}