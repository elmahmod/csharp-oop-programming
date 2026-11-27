
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
        public void Greet()
        {
            Console.WriteLine($"Hi, my name is {FullName} and my Id is {Id}");
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
        public void Work()
        {
            Console.WriteLine($"I work at {DepartmentName} and earn {Salary:C}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Up-casting
            Employee employee = new Employee(1, "muhamed", "el mahmod", "Mr.", 250, "CS");
            Person person = employee;
            person.Greet();

            // Down-casting ( no one usually use this method..)
            Person person2 = new Employee(2, "muhamed", "el mahmod", "Mr.", 250, "CS");
            Employee employee2 = (Employee)person2;
            employee2.Work();

            // Invalid Down-casting
            //Person person3 = new Person(3, "muhamed", "el mahmod", "Mr.");
            //Employee employee3 = (Employee)person3;

        }
    }
}
