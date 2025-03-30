using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public Employee[] Employees { get; set; }
        private int employeeCount = 0;
        public Department(string name, int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
            Employees = new Employee[EmployeeLimit];
        }
        public void AddEmployee(Employee employee)
        {
            if (employeeCount < EmployeeLimit)
            {
                Employees[employeeCount] = employee;
                employeeCount++;
                Console.WriteLine($"{employee.name} was added to the department.");
            }
            else
            {
                Console.WriteLine("Cannot add more employees.");
            }
        }
        public void GetAllEmployees()
        {
            Console.WriteLine($"Department: {Name}");
            Console.WriteLine("Employee List:");
            for (int i = 0; i < employeeCount; i++)
            {
                Employees[i].ShowInfo();
            }
        }
    }
}
