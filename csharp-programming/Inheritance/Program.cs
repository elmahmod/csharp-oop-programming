
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Base Class
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

        public virtual void Print()
        {
            Console.WriteLine("I'm the print method from the base class");
        }

        public void ShowRole()
        {
            Console.WriteLine("I'm a Person.");
        }
    }

    // Derived Class: Employee IS-A Person.
    public class Employee : Person
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

        public override void Print()
        {
            Console.WriteLine("I'm the print method from the derived class");
            //base.Print();
        }

        public new void ShowRole()
        {
            Console.WriteLine("I'm an Employee.");
        }
    }

    // Multilevel Inheritance: Doctor -> Employee -> Person
    public class Doctor : Employee
    {
        public Doctor(int id, string firstName, string lastName, string title,
            float salary, string departmentName, string specialty)
            : base(id, firstName, lastName, title, salary, departmentName)
        {
            Specialty = specialty;
        }

        public string Specialty { get; set; }

        public void Heal()
        {
            Console.WriteLine($"Doctor {FullName} specializes in {Specialty}.");
        }
    }

    // Hierarchical Inheritance: User and Employee inherit from Person.
    public class User : Person
    {
        public User(int id, string firstName, string lastName, string title,
            string username, string password, int permission)
            : base(id, firstName, lastName, title)
        {
            Username = username;
            Password = password;
            Permission = permission;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }

        public void Info()
        {
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"Permission: {Permission}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Upcasting
            Employee employee = new Employee(1, "muhamed", "el mahmod", "Mr.", 250, "CS");
            Person person = employee;
            person.Greet();


            // Downcasting
            Person person2 = new Employee(2, "muhamed", "el mahmod", "Mr.", 250, "CS");
            Employee employee2 = (Employee)person2;
            employee2.Work();


            // Invalid Downcasting: Check with 'is' before casting.
            Person person3 = new Person(3, "Ahmed", "Ali", "Mr.");

            if (person3 is Employee)
            {
                Employee employee3 = (Employee)person3;
                employee3.Work();
            }
            else
            {
                Console.WriteLine("This person is not an Employee.");
            }


            // Safe Downcasting using 'as'
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


            // Pattern Matching
            Person person5 = new Employee(5, "Sara", "Ali", "Ms.", 500, "IT");

            if (person5 is Employee employee5)
            {
                person5.Greet();
                employee5.Work();
            }


            // Method Overriding
            Console.WriteLine("\n--- Method Overriding ---");

            employee.Print(); // Employee.Print()
            person.Print();   // Employee.Print()

            Person basePerson = new Person(6, "Omar", "Ali", "Mr.");
            basePerson.Print(); // Person.Print()


            // Method Hiding
            Console.WriteLine("\n--- Method Hiding ---");

            employee.ShowRole();   // Employee.ShowRole()
            person.ShowRole();     // Person.ShowRole()
            basePerson.ShowRole(); // Person.ShowRole()


            // Multilevel Inheritance
            Console.WriteLine("\n--- Multilevel Inheritance ---");

            Doctor doctor = new Doctor(
                7, "Ahmed", "Ali", "Dr.", 1500, "Cardiology", "Cardiologist"
            );

            doctor.Greet();
            Console.WriteLine($"Full Name: {doctor.FullName}");

            doctor.Work();
            doctor.IncreaseSalaryByAmount(500);
            Console.WriteLine($"Salary After Increase: {doctor.Salary}");

            Console.WriteLine($"Specialty: {doctor.Specialty}");
            doctor.Heal();

            doctor.Print();
            doctor.ShowRole();


            // Multilevel Upcasting
            Console.WriteLine("\n--- Multilevel Upcasting ---");

            Employee employeeDoctor = doctor;
            Person personDoctor = doctor;

            employeeDoctor.Work();
            personDoctor.Greet();
            personDoctor.Print();


            // Hierarchical Inheritance
            Console.WriteLine("\n--- Hierarchical Inheritance ---");

            User user = new User(
                8, "Mohammed", "Ali", "Mr.", "mohammed123", "12345", 1
            );

            user.Greet();
            Console.WriteLine($"Full Name: {user.FullName}");
            user.Info();


            // Upcasting: User -> Person
            Person personUser = user;

            personUser.Greet();
            personUser.Print();
            personUser.ShowRole();
        }
    }
}
