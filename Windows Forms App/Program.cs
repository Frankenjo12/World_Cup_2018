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
                Application.Run(new Favorite_National_Team());
            }
            else
            {
                Application.Run(new Initial_settings());
            }
        }
    }
}