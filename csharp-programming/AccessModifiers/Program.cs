
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class clsA
    {
        // Fields / Members
        public int x1 = 10;       // Accessible from anywhere the class is accessible
        protected int x2 = 20;    // Accessible within this class and derived classes
        private int x3 = 30;      // Accessible only within this class

        // Methods
        public int func1()        // Accessible from anywhere the class is accessible
        {
            return 100;
        }

        protected int func2()     // Accessible within this class and derived classes
        {
            return 200;
        }

        private int func3()       // Accessible only within this class
        {
            return 300;
        }
    }

    // clsB inherits from clsA
    class clsB : clsA
    {
        public int func4()
        {
            // Correct: Public and protected members are accessible in derived classes
            return x1 + x2 + func1() + func2();

            // Wrong: Private members of clsA are not accessible directly in clsB
            //return x1 + x2 + x3 + func1() + func2() + func3();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of clsA
            clsA a = new clsA();

            // Only public members are accessible here
            Console.WriteLine(a.x1 + a.func1());


            // Create an object of clsB
            clsB b1 = new clsB();

            // Access public members inherited from clsA and defined in clsB
            Console.WriteLine(b1.x1 + b1.func1() + b1.func4());
        }
    }
}
