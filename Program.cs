namespace calorieCalulator
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
            GlobalVariables.sQLiteDatabase  = new SQLiteDatabase("C:\\Users\\Kareem Ayman\\source\\repos\\calorieCalulator\\superfit.db");
            GlobalVariables.person = GlobalVariables.sQLiteDatabase.GetLastPerson();

            ApplicationConfiguration.Initialize();
            Application.Run(new Splashscreen());
        }
    }
}