
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // (Base / Parent / super) Class
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public string FullName
        {
            get { return FirstName + ' ' + LastName; }
        }
    }

    // (Derived / Child / sub) Class
    public class Employee : Person // IS-A Relationship: Employee is a Person.
    {
        public float Salary { get; set; }
        public string DepartmentName { get; set; }

        public void IncreaseSalaryByAmount(float amount)
        {
            Salary += amount;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Id = 1;
            employee.Title = "Mr.";
            employee.FirstName = "muhamed";
            employee.LastName = "el mahmod";

            employee.DepartmentName = "CS";
            employee.Salary = 250;

            Console.WriteLine($"Id: {employee.Id}");
            Console.WriteLine($"Title: {employee.Title}");
            Console.WriteLine($"Full Name: {employee.FullName}");
            Console.WriteLine($"Department Name: {employee.DepartmentName}");
            Console.WriteLine($"Salary: {employee.Salary}");

            employee.IncreaseSalaryByAmount(50);

            Console.WriteLine($"Salary After Increase: {employee.Salary}");
        }
    }
}
