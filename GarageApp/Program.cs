using GarageApp.Contracts;

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

            //Console.WriteLine("Bruh"); // Write to console window
            //System.Diagnostics.Debug.WriteLine("Bruh"); // Write to immediate window

            Employees employees = Employees.GetInstance();

            ApplicationConfiguration.Initialize();
            Application.Run(new AuthenticationForm());
        }
    }
}