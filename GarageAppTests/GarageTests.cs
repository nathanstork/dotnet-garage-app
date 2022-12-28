using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (Garage.Jobs.Count == previousCount + 1 && previousCount != 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void RemoveJobTest()
        {
            Job newJob = new Job("", "", 999, new Car("", "", "", CarColor.Black), new Customer("", "", "", ""));

            Garage.AddJob(newJob);

            int previousCount = Garage.Jobs.Count;

            Garage.Jobs.Remove(newJob);

            if (Garage.Jobs.Count == previousCount - 1)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void GetTotalProfitTest()
        {
            int previousProfit = Garage.GetTotalProfit();
            Console.WriteLine(previousProfit);
            Console.WriteLine(Garage.Jobs.Count);

            Garage.Jobs.Add(new Job("", "10/10/2000", 200, new Car("", "", "", CarColor.Black), new Customer("", "", "", "")));
            Garage.Jobs.Add(new Job("", "3/3/2020", 200, new Car("", "", "", CarColor.Black), new Customer("", "", "", "")));
            Garage.Jobs.Add(new Job("", "9/5/2021", 200, new Car("", "", "", CarColor.Black), new Customer("", "", "", "")));
            Garage.Jobs.Add(new Job("", "31/6/2035", 200, new Car("", "", "", CarColor.Black), new Customer("", "", "", "")));
            Garage.Jobs.Add(new Job("", "24/11/2022", 200, new Car("", "", "", CarColor.Black), new Customer("", "", "", "")));

            int newProfit = Garage.GetTotalProfit();
            Console.WriteLine(newProfit);

            if (previousProfit + (5 * 200) == newProfit)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
