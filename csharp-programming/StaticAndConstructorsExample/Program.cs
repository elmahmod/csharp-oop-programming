
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndConstructorsExample
{
    class Person
    {
        // Auto-Implemented Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Parameterized Constructor
        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        // Print the person's details.
        public void PrintDetails()
        {
            Console.WriteLine("Id   : {0}", this.Id);
            Console.WriteLine("Name : {0}", this.Name);
            Console.WriteLine("Age  : {0}", this.Age);
            Console.WriteLine();
        }

        // Find a person by ID.
        public static Person Find(int id)
        {
            // Simulate a search result for now.
            // Later, we will connect to a database.
            if (id == 10)
                return new Person(10, "Mohammed el mahmod", 45);

            return null;
        }

        // Find a person by username and password.
        public static Person Find(string username, string password)
        {
            // Simulate a search result.
            if (username == "admin" && password == "123")
                return new Person(1, "Admin el mahmod", 20);

            return null;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person(10, "mohamed", 45);


            // Find a person by ID.
            Console.WriteLine("Find person by ID");

            Person person = Person.Find(10);

            if (person == null)
            {
                Console.WriteLine("Could not find a person with the given ID.");
                return;
            }

            person.PrintDetails();


            // Find a person by username and password.
            Console.WriteLine("Find person by username and password");

            Person person2 = Person.Find("admin", "123");

            if (person2 == null)
            {
                Console.WriteLine("Could not find a person with the given credentials.");
                return;
            }

            person2.PrintDetails();


            // Find a person using invalid credentials.
            Console.WriteLine("Find person by username and password");

            Person person3 = Person.Find("user1", "1235");

            if (person3 == null)
            {
                Console.WriteLine("Could not find a person with the given credentials.");
                return;
            }

            person3.PrintDetails();
        }
    }
}
