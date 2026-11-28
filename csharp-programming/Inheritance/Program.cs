
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Base / Parent / Super Class
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

        // Method Overriding: Can be overridden in a derived class.
        public virtual void Print()
        {
            Console.WriteLine("I'm the print method from the base class");
        }

        // Method Hiding: Non-virtual method in the base class.
        public void ShowRole()
        {
            Console.WriteLine("I'm a Person.");
        }
    }

    // Derived / Child / Subclass
    public class Employee : Person // IS-A Relationship: Employee is a Person.
    {
        public Employee(int id, string firstName, string lastName, string title,
            float salary, string departmentName)
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

        // Method Overriding: Replaces the inherited virtual implementation.
        public override void Print()
        {
            Console.WriteLine("I'm the print method from the derived class");
            //base.Print();
        }

        // Method Hiding: Hides the base class method.
        // The method called depends on the reference type.
        public new void ShowRole()
        {
            Console.WriteLine("I'm an Employee.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Upcasting: Implicitly convert an Employee reference to a Person reference.
            // This is safe because Employee inherits from Person.
            Employee employee = new Employee(1, "muhamed", "el mahmod", "Mr.", 250, "CS");
            Person person = employee;
            person.Greet();


            // Downcasting: Explicitly convert a Person reference back to Employee.
            // This succeeds because the actual object is an Employee.
            Person person2 = new Employee(2, "muhamed", "el mahmod", "Mr.", 250, "CS");
            Employee employee2 = (Employee)person2;
            employee2.Work();


            // Invalid Downcasting: A Person object cannot be cast to Employee.
            // Use 'is' to check the object's type before casting.
            Person person3 = new Person(3, "Ahmed", "Ali", "Mr.");

            if (person3 is Employee)
            {
                // This executes only if person3 refers to an Employee object.
                Employee employee3 = (Employee)person3;
                employee3.Work();
            }
            else
            {
                Console.WriteLine("This person is not an Employee.");
            }


            // Safe Downcasting using 'as'.
            // Returns null if the object cannot be converted to Employee.
            Person person4 = new Person(4, "Omar", "Ali", "Mr.");

            Employee employee4 = person4 as Employee;

            if (employee4 != null)
            {
                employee4.Work();
            }
            else
            {
                Console.WriteLine("Casting failed.");
            }


            // Pattern Matching: Check the type and declare a variable in one step.
            // The variable employee5 is available when the type check succeeds.
            Person person5 = new Employee(5, "Sara", "Ali", "Ms.", 500, "IT");

            if (person5 is Employee employee5)
            {
                person5.Greet();
                employee5.Work();
            }


            // Method Overriding: The actual object type determines the method.
            Console.WriteLine("\n--- Method Overriding ---");

            employee.Print(); // Employee.Print()
            person.Print();   // Employee.Print()

            Person basePerson = new Person(6, "Omar", "Ali", "Mr.");
            basePerson.Print(); // Person.Print()


            // Method Hiding: The reference type determines the method.
            Console.WriteLine("\n--- Method Hiding ---");

            employee.ShowRole(); // Employee.ShowRole()
            person.ShowRole();   // Person.ShowRole()
            basePerson.ShowRole(); // Person.ShowRole()
        }
    }
}
