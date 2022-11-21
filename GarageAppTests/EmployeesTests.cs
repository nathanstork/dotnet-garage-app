using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GarageAppTests
{
    // Arrange
    // Act
    // Assert

    public class Tests
    {
        private Employees employees;

        [SetUp]
        public void Setup()
        {
            employees = Employees.GetInstance();

            Trace.Listeners.Add(new ConsoleTraceListener());
        }

        [Test]
        public void SuccessfullLoginTest()
        {
            try
            {
                employees.Login("admin", "password");
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
                employees.Login(Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.Pass();
            }
        }
    }
}