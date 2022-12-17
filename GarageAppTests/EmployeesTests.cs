using GarageApp.Contracts;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GarageAppTests
{
    // Arrange
    // Act
    // Assert

    public class EmployeesTests
    {
        private Employees Employees;
        private string SaveFilePath;

        [SetUp]
        public void Setup()
        {
            Employees = Employees.GetInstance();

            SaveFilePath = Employees.SaveFilePath;

            Trace.Listeners.Add(new ConsoleTraceListener());
        }

        [Test]
        public void SuccessfullLoginTest()
        {
            try
            {
                Employees.LogIn("admin", "password");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void UnsuccessfullLoginTest()
        {
            try
            {
                Employees.LogIn(Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void LogoutTest()
        {
            Employees.LogIn("admin", "password");
            Employees.LogOut();

            if (Employees.CurrentUser == null)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void SaveDataTest()
        {
            GarageApp.Users.Mechanic newMechanic = new GarageApp.Users.Mechanic("user", "pass", "name", "address", new MonthlyContract(1, 1));
            Employees.Mechanics.Add(newMechanic);

            GarageApp.Users.Manager newManager = new GarageApp.Users.Manager("user", "pass", "name", "address", Employees.Mechanics);
            Employees.Managers.Add(newManager);

            Employees.SaveData();

            // Serialize current managers and mechanics
            // Deserialize save file 
            // Compare resulting strings

            // Revert changes
            Employees.Mechanics.Remove(newMechanic);
            Employees.Managers.Remove(newManager);
            Employees.SaveData();
        }
    }
}