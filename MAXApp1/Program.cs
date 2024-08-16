namespace MAXApp1
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
            //2024/08/16½Õ¾ãªì©lForm
            //Application.Run(new Form1());
            Application.Run(new Formfiles());
        }
    }
}