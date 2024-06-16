using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement
{
    public class EmployeeManager
    {
        private List<Employee> _employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            _employees.Add(employee);
        }

        public bool RemoveEmployee(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return false;

            _employees.Remove(employee);
            return true;
        }

        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public List<Employee> GetAllEmployees()
        {
            return new List<Employee>(_employees);
        }

        public double GetTotalSalary()
        {
            return _employees.Sum(e => e.Salary);
        }

        public double GetAverageSalary()
        {
            if (!_employees.Any())
                throw new InvalidOperationException("No employees in the list.");

            return _employees.Average(e => e.Salary);
        }
    }
}

