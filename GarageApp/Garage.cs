namespace GarageApp
{
    [Serializable]
    internal class Garage
    {
        private static Garage? _instance;

        internal List<Job> Jobs = new List<Job>();

        private Garage()
        {
            // Example jobs
            /*Jobs.Add(new Job(
                "Test description",
                "02/07/2021",
                95,
                new Car("DZ-05-37", "Yaris", "Toyota", CarColor.Black),
                new Customer("Michelle de Haan", "Schoolstraat 53 Eindhoven", "mdehaan@gmail.nl", "+31 0678453925")
            ));
            Jobs.Add(new Job(
                "Test description 2",
                "10/10/2022",
                220,
                new Car("DZ-05-37", "Yaris", "Toyota", CarColor.Black),
                new Customer("Brigit Duivenbloemen", "Cobralaan 2 Helmond", "bduivenb@hotmail.nl", "+31 0627384622")
            ));
            Jobs.Add(new Job(
                "Test description 3",
                "11/10/2022",
                140,
                new Car("VE-39-00", "5 serie", "BMW", CarColor.Black),
                new Customer("Alex van Oost", "Kanaalweg 43 Valkenswaard", "alex1674@gmail.nl", "+31 0611753856")
            ));
            Jobs.Add(new Job(
                "Test description 4",
                "12/10/2022",
                80,
                new Car("AL-15-19", "A1", "Audi", CarColor.Black),
                new Customer("Timo Smit", "Groenedijk 6 Eindhoven", "timo.smit@hotmail.com", "+31 0686339675")
            ));
            Jobs.Add(new Job(
                "Test description 5",
                "23/11/2022",
                300,
                new Car("EB-HO-23", "Golf", "Volkswagen", CarColor.Grey),
                new Customer("Tom van Ack", "Frieschestraat 31 Helmond", "tvack@hotmail.nl", "+31 0679035561")
            ));
            Jobs.Add(new Job(
                "Test description 6",
                "24/11/2022",
                450,
                new Car("01-BHK-4", "Polo", "Volkswagen", CarColor.Navy),
                new Customer("Pim de Jonge", "Gamerstraat 4 Valkenswaard", "pdejonge@gmail.nl", "+31 0636851288")
            ));
            Jobs.Add(new Job(
                "Test description 7",
                "25/11/2022",
                125,
                new Car("8-DJZ-49", "A7", "Audi", CarColor.Black),
                new Customer("Luke Cornelissen", "Emmasingel 11 Eindhoven", "email@gmail.be", "+31 0623775123")
            ));
            Jobs.Add(new Job(
                "Test description 8",
                "28/11/2022",
                250,
                new Car("AB-33-KL", "A1", "Audi", CarColor.Black),
                new Customer("Nate de Vries", "Woenselscheweg 8 Eindhoven", "vriesnate@gmail.com", "+31 0674482356")
            ));*/
        }

        internal static Garage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Garage();
            }
            return _instance;
        }

        private List<Job> GetJobsByDate(int month, int year)
        {
            List<Job> jobs = Jobs.FindAll(job =>
            {
                string[] nums = job.Date.Split("/"); //02

                return Int32.Parse(nums[1]) == month && Int32.Parse(nums[2]) == year;
            });

            Console.WriteLine(jobs.Count.ToString());

            return jobs;
        }

        internal int GetMonthlyProfit(int month, int year)
        {
            int gainings = 0;
            int costs = 0;

            List<Job> monthsJobs = GetJobsByDate(month, year);

            foreach (Job job in monthsJobs)
            {
                if (job.Status == JobStatus.Completed || job.Status == JobStatus.UnableToComplete)
                {
                    gainings += (job.Price + job.Costs);
                    costs += job.LabourCosts;
                }
            }

            return gainings - costs;
        }

        internal int GetTotalProfit()
        {
            int gainings = 0;
            int costs = 0;

            foreach (Job job in Jobs)
            {
                if (job.Status == JobStatus.Completed || job.Status == JobStatus.UnableToComplete)
                {
                    gainings += (job.Price + job.Costs);
                    costs += job.LabourCosts;
                }
            }

            return gainings - costs;
        }
    }
}
