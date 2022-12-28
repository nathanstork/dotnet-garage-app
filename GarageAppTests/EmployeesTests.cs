using GarageApp.Contracts;
using GarageApp.Users;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;

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

            if (Employees.CurrentUser != null) Assert.Fail();
        }

        [Test]
        public void SaveDataTest()
        {
            string randomUsername = Guid.NewGuid().ToString();
            string randomPassword = Guid.NewGuid().ToString();
            string randomName = Guid.NewGuid().ToString();
            string randomAddress = Guid.NewGuid().ToString();

            GarageApp.Users.Mechanic newMechanic = new GarageApp.Users.Mechanic(
                randomUsername, randomPassword, randomName, randomAddress, new MonthlyContract(1, 1)
            );
            Employees.Mechanics.Add(newMechanic);

            GarageApp.Users.Manager newManager = new GarageApp.Users.Manager(
                randomUsername, randomPassword, randomName, randomAddress, new MonthlyContract(1, 1), Employees.Mechanics
            );
            Employees.Managers.Add(newManager);

            Employees.SaveData();

            Stream stream = File.Open(SaveFilePath, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            ValueTuple<List<Mechanic>, List<Manager>> data = (ValueTuple<List<Mechanic>, List<Manager>>) binaryFormatter.Deserialize(stream);

            if (!data.Item1.Contains(newMechanic) || !data.Item2.Contains(newManager))
            {
                Assert.Fail();
            }

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