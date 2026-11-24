
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    // Static Class: Cannot be instantiated.
    static class Settings
    {
        // Read-Only Static Property
        public static int DayNumber
        {
            get { return DateTime.Today.Day; }
        }

        // Read-Only Static Property
        public static string DayName
        {
            get { return DateTime.Today.DayOfWeek.ToString(); }
        }

        // Auto-Implemented Static Property (Read/Write)
        public static string ProjectPath
        {
            get;
            set;
        }
    }

    class Employee
    {
        // Private Fields
        private int _id = 1; // Backing field for a read-only property
        private string _name;

        // Auto-Implemented Property
        public string Phone
        {
            get;
            set;
        }

        // Read-Only Property
        public int Id
        {
            get
            {
                return _id;
            }
        }

        // Read/Write Property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            // Set property values
            employee.Name = "Muhammed";
            employee.Phone = "023535";

            // Get property values
            Console.WriteLine($"ID: {employee.Id}");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Phone: {employee.Phone}");

            Console.WriteLine();

            // Access static properties directly through the class.
            Console.WriteLine($"Day Number: {Settings.DayNumber}");
            Console.WriteLine($"Day Name: {Settings.DayName}");

            // Set the value of a static auto-implemented property.
            Settings.ProjectPath = @"C:\MyProjects";

            // Get the value of a static auto-implemented property.
            Console.WriteLine($"Project Path: {Settings.ProjectPath}");

            //Settings settings = new Settings(); // Wrong: Cannot instantiate a static class.
            //employee.Id = 10; // Wrong: Id is a read-only property.
        }
    }
}
