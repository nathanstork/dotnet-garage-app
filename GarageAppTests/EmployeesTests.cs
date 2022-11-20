using System.Runtime.CompilerServices;

namespace GarageAppTests
{
    public class Tests
    {
        private Employees employees;

        [SetUp]
        public void Setup()
        {
            employees = Employees.GetInstance();
        }

        [Test]
        public void TestTest()
        {
            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            // Arrange
            employee
            // Act
            // Assert
        }
    }
}