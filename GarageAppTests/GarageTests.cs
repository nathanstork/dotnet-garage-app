using System.Diagnostics;

namespace GarageAppTests
{
    internal class GarageTests
    {
        private Employees Employees;
        private Garage Garage;

        [SetUp]
        public void Setup()
        {
            Employees = Employees.GetInstance();

            Employees.LogIn("admin", "password");

            Garage = Employees.CurrentUser.Garage;

            Trace.Listeners.Add(new ConsoleTraceListener());
        }

        [Test]
        public void AddJobTest()
        {
            int previousCount = Garage.Jobs.Count;

            Job newJob = new Job("", "", 999, new Car("", "", "", CarColor.Black), new Customer("", "", "", ""));

            Garage.AddJob(newJob);

            if (Garage.Jobs.Count != previousCount + 1)
            {
                Assert.Fail();
            }

            Garage.Jobs.Remove(newJob);
        }

        [Test]
        public void RemoveJobTest()
        {
            Job newJob = new Job("", "", 999, new Car("", "", "", CarColor.Black), new Customer("", "", "", ""));

            Garage.AddJob(newJob);

            int previousCount = Garage.Jobs.Count;

            Garage.Jobs.Remove(newJob);

            if (Garage.Jobs.Count != previousCount - 1)
            {
                Assert.Fail();
            }
        }

        private List<Job> GetNewJobs(int price)
        {
            List<Job> newJobs = new List<Job>();

            newJobs.Add(new Job("", "10/10/2000", price, new Car("", "", "", CarColor.Black), new Customer("", "", "", "")));
            newJobs.Add(new Job("", "3/3/2020", price, new Car("", "", "", CarColor.Black), new Customer("", "", "", "")));
            newJobs.Add(new Job("", "9/5/2021", price, new Car("", "", "", CarColor.Black), new Customer("", "", "", "")));
            newJobs.Add(new Job("", "31/6/2035", price, new Car("", "", "", CarColor.Black), new Customer("", "", "", "")));
            newJobs.Add(new Job("", "24/11/2022", price, new Car("", "", "", CarColor.Black), new Customer("", "", "", "")));

            return newJobs;
        }

        [Test]
        public void GetTotalProfitTest()
        {
            int previousProfit = Garage.GetTotalProfit();

            // Get new jobs with equal price
            List<Job> newJobs = GetNewJobs(200);

            // Add and set all new jobs with equal costs
            newJobs.ForEach(job => {
                job.Status = JobStatus.Completed;
                job.Costs = 50;
                job.LabourCosts = 25;

                Garage.AddJob(job);
            });

            int newProfit = Garage.GetTotalProfit();

            if (previousProfit + (5 * (200 + 50)) - (5 * 25) != newProfit)
            {
                Assert.Fail();
            }

            // Remove all newly added jobs
            newJobs.ForEach(job => {
                Garage.RemoveJob(job);
            });
        }

        [Test]
        public void GetMonthlyProfitTest()
        {
            // Get new jobs with equal price
            List<Job> newJobs = GetNewJobs(250);

            // Add and set all new jobs with equal costs
            newJobs.ForEach(job => {
                string[] dateChunks = job.Date.Split("/");

                int previousProfit = (Garage.GetMonthlyProfit(Convert.ToInt32(dateChunks[1]), Convert.ToInt32(dateChunks[2])));

                job.Status = JobStatus.UnableToComplete;
                job.Costs = 75;
                job.LabourCosts = 50;

                Garage.AddJob(job);

                int newProfit = (Garage.GetMonthlyProfit(Convert.ToInt32(dateChunks[1]), Convert.ToInt32(dateChunks[2])));

                if (previousProfit + 250 + 75 - 50 != newProfit) Assert.Fail();
            });

            // Remove all newly added jobs
            newJobs.ForEach(job => {
                Garage.RemoveJob(job);
            });
        }
    }
}
