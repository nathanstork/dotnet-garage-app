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
            //System.Diagnostics.Debug.WriteLine("Nigger"); // Write to immediate window

            //Job newJob = new Job(0, JobType.Medium, "Test description", 1200, 0, 0, 0);
            Manager manager = new Manager();

            Mechanic mechanic = new Mechanic();

            Garage garage = Garage.GetInstance();
            IdGenerator idGenerator = IdGenerator.GetInstance();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(idGenerator.GetId());
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new AuthenticationForm());
        }
    }
}