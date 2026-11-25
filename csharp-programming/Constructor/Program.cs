using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Temp
    {
        public static string tp { get; set; }
        private Temp()
        {

        }
    }

    static class Settings
    {
        public static int DayNumber
        {
            get { return DateTime.Today.Day; }
        }

        public static string DayName
        {
            get { return DateTime.Today.DayOfWeek.ToString(); }
        }

        public static string ProjectPath
        {
            get;
        }

        static Settings()   // Static Constructor (cannot recive parameters) // calls only one time
        {
            ProjectPath = @"C:\vidoes\";
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person()     // Parameterless Constructor
        {
            Id = -1;
            Name = "Empty";
            Age = 0;
        }

        public Person(int id, string name, int age)     // Parameterized Constructor
        {
            Id = id;
            Name = name;
            Age = age;
        }

        ~Person()   // Destructor
        {
            Console.WriteLine("Destructor called.");
        }

        public void Print()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(Age);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Print();

            Console.WriteLine();

            Person person2 = new Person(93, "mohamed", 15);
            person2.Print();

            Console.WriteLine();

            Console.WriteLine("Default Constructor:\r\nIf we have not defined a" +      // Default Constructor
                " constructor in our class,\n then the C# will automatically create" +
                " a default constructor with an empty code and no parameters.");

            Console.WriteLine();

            Console.WriteLine("we cannot create objects of the satatic class or within Private Constructor");       // Private Constructor and Static Class
            //Settings obj = new Settings(); Static class
            //Temp obj = new Temp(); Private Constructor!
            Console.WriteLine();

        }
    }
}
