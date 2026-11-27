
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // (Base / Parent / super) Class
    public class Person
    {
        public Person(int id, string firstName, string lastName, string title)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
        }
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
        public Employee(int id, string firstName, string lastName, string title, float salary, string departmentName)
            : base(id, firstName, lastName, title)
        {
            Salary = salary;
            DepartmentName = departmentName;
        }
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
            Employee employee = new Employee(1, "muhamed", "el mahmod", "Mr.", 250, "CS");

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
