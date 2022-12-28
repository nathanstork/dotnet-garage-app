using System.Diagnostics;

namespace GarageAppTests
{
    // Arrange
    // Act
    // Assert

    public class EmployeesTests
    {
        private Employees Employees;

        [SetUp]
        public void Setup()
        {
            Employees = Employees.GetInstance();

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

            Employees.LogOut(); // Clean up by logging out
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
    }
}