namespace GarageApp
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

            //Console.WriteLine("Hello world!"); // Write to console window
            //System.Diagnostics.Debug.WriteLine("Hello world!"); // Write to immediate window

            ApplicationConfiguration.Initialize();
            Application.Run(new AuthenticationForm());
        }
    }
}