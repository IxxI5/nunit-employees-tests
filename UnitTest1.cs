using NUnit.Framework;
using EmployeeManagement;
using System;

namespace EmployeeManagementTests
{
    [TestFixture]
    public class EmployeeManagerTests
    {
        private EmployeeManager _employeeManager;

        [SetUp]
        public void SetUp()
        {
            // Arrange
            _employeeManager = new EmployeeManager();
        }

        [Test]
        public void AddEmployee_WhenCalled_AddsEmployeeToList()
        {
            // Arrange
            var employee = new Employee(1, "John Doe", 50000);

            // Act
            _employeeManager.AddEmployee(employee);
            var result = _employeeManager.GetEmployee(1);

            // Assert
            Assert.That(result, Is.EqualTo(employee));
        }

        [Test]
        public void RemoveEmployee_WhenCalled_RemovesEmployeeFromList()
        {
            // Arrange
            var employee = new Employee(1, "John Doe", 50000);
            _employeeManager.AddEmployee(employee);

            // Act
            var result = _employeeManager.RemoveEmployee(1);

            // Assert
            Assert.IsTrue(result);
            Assert.IsNull(_employeeManager.GetEmployee(1));
        }

        [Test]
        public void RemoveEmployee_EmployeeNotFound_ReturnsFalse()
        {
            // Act
            var result = _employeeManager.RemoveEmployee(1);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void GetEmployee_EmployeeExists_ReturnsEmployee()
        {
            // Arrange
            var employee = new Employee(1, "John Doe", 50000);
            _employeeManager.AddEmployee(employee);

            // Act
            var result = _employeeManager.GetEmployee(1);

            // Assert
            Assert.That(result, Is.EqualTo(employee));
        }

        [Test]
        public void GetEmployee_EmployeeDoesNotExist_ReturnsNull()
        {
            // Act
            var result = _employeeManager.GetEmployee(1);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void GetAllEmployees_WhenCalled_ReturnsAllEmployees()
        {
            // Arrange
            var employee1 = new Employee(1, "John Doe", 50000);
            var employee2 = new Employee(2, "Jane Smith", 60000);
            _employeeManager.AddEmployee(employee1);
            _employeeManager.AddEmployee(employee2);

            // Act
            var result = _employeeManager.GetAllEmployees();

            // Assert
            Assert.That(result.Count, Is.EqualTo(2));
            CollectionAssert.Contains(result, employee1);
            CollectionAssert.Contains(result, employee2);
        }

        [Test]
        public void GetTotalSalary_WhenCalled_ReturnsSumOfAllSalaries()
        {
            // Arrange
            var employee1 = new Employee(1, "John Doe", 50000);
            var employee2 = new Employee(2, "Jane Smith", 60000);
            _employeeManager.AddEmployee(employee1);
            _employeeManager.AddEmployee(employee2);

            // Act
            var result = _employeeManager.GetTotalSalary();

            // Assert
            Assert.That(result, Is.EqualTo(110000));
        }

        [Test]
        public void GetAverageSalary_WhenCalled_ReturnsAverageSalary()
        {
            // Arrange
            var employee1 = new Employee(1, "John Doe", 50000);
            var employee2 = new Employee(2, "Jane Smith", 60000);
            _employeeManager.AddEmployee(employee1);
            _employeeManager.AddEmployee(employee2);

            // Act
            var result = _employeeManager.GetAverageSalary();

            // Assert
            Assert.That(result, Is.EqualTo(55000));
        }

        [Test]
        public void GetAverageSalary_NoEmployees_ThrowsInvalidOperationException()
        {
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => _employeeManager.GetAverageSalary());
        }

        [Test]
        public void AddEmployee_NullEmployee_ThrowsArgumentNullException()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _employeeManager.AddEmployee(null));
        }

        [Test]
        public void AddEmployee_WithMultipleEmployees_ValidatesCorrectly()
        {
            // Arrange
            var employee1 = new Employee(1, "John Doe", 50000);
            var employee2 = new Employee(2, "Jane Smith", 60000);
            var employee3 = new Employee(3, "Sam Brown", 70000);

            // Act
            _employeeManager.AddEmployee(employee1);
            _employeeManager.AddEmployee(employee2);
            _employeeManager.AddEmployee(employee3);

            var allEmployees = _employeeManager.GetAllEmployees();

            // Assert
            Assert.That(allEmployees.Count, Is.EqualTo(3));
            CollectionAssert.Contains(allEmployees, employee1);
            CollectionAssert.Contains(allEmployees, employee2);
            CollectionAssert.Contains(allEmployees, employee3);
        }
    }
}
