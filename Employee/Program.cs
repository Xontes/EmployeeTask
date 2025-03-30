//Employee class

//Name
//Salary
//ShowInfo()

//Name ve salary teyin edilmemish employee obyekti yaratmaq olmaz.

//Department
//Name
//EmployeeLimit -> Departmentde ola bilecek maksimum employee sayini gosterir
//Employees-> bu bir arraydir ve icinde Employee obyektlerini saxlayacaq

//AddEmployee() -> parametr olaraq bir Employee obyekti qebul edecek eger yuxarida olan Employees arrayin uzunlugu employeeLimiti kecmirse qebul etdiyi Employee obyektini yuxarida olan Employees arrayine elave edecek.
//GetAllEmployees() -> butun employeeleri geriye qaytaracaq.

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee0 = new Employee("Bertholdth", 5000);
            Employee employee1 = new Employee("WOAHHHHHHH", 1200);
            Employee employee2 = new Employee("WOOUUHHHHH", 2500);
            Employee employee3 = new Employee("RAHHHHHHHH", 1500);
            Employee employee4 = new Employee("BZZZZZZZZZ", 9500);
            Department department = new Department("wroom wroom company",4);
            department.AddEmployee(employee0);
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);
            department.AddEmployee(employee3);
            department.AddEmployee(employee4);
            department.GetAllEmployees();
        }
    }
}
