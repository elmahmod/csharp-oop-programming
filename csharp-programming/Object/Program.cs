using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class clsPerson
    {
        // Members / Fields
        public string FirstName;
        public string LastName;

        // Methods
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson person1 = new clsPerson();
            person1.FirstName = "Muhammed";
            person1.LastName = "EL Mahmod";
            Console.WriteLine(person1.FullName());


            clsPerson person2 = new clsPerson { FirstName = "ibarhim", LastName = "Ali" };
            Console.WriteLine(person2.FullName());
        }
    }
}
