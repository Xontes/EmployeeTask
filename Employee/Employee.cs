using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employee
    {
        public string name;
        public int salary;

        public Employee(string name,int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {this.name} Salary: {this.salary}$");
        }
    }
}
