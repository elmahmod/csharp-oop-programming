
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembersMethods
{
    class clsA
    {
        // Instance field: Each object has its own copy.
        public int x1;

        // Static field: Shared among all objects of this class.
        public static int x2;

        // Instance method: Called through an object.
        public int method1()
        {
            // Instance methods can access both instance and static members.
            // Why? Because they have access to the current object (this).
            return x1 + x2 + method2();
        }

        // Static method: Called through the class.
        public static int method2()
        {
            //return x2 + x1; // Wrong: Cannot access x1 directly.

            // Static methods can directly access static members.
            // They can access instance members only through an object.
            return x2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsA a1 = new clsA();

            // Access an instance field through an object.
            a1.x1 = 10;

            // Access an instance field and method through an object.
            Console.WriteLine(a1.x1 + a1.method1());


            clsA a2 = new clsA();
            a2.x1 = 500;

            // Each object has its own x1 value.
            Console.WriteLine(a1.x1);
            Console.WriteLine(a2.x1);


            //a1.x2 = 20; // Wrong: Access static members through the class.
            //a1.method2(); // Wrong: Call static methods through the class.

            clsA.x2 = 20;

            // All objects share the same static field x2.
            // Its value is now 20 for both a1 and a2.

            Console.WriteLine(clsA.method2());


            // Example: Both objects use the shared static field.
            Console.WriteLine(a1.method1());
            Console.WriteLine(a2.method1());
        }
    }


    // Example: Conceptual Memory Representation
    /*
        Class: clsA
        ______________________________________

        Static (Shared):
        [ x2 = 20 ]
        [ method2() ]
        ______________________________________

        Object a1              Object a2
        [ x1 = 10 ]           [ x1 = 500 ]

        Both objects can call method1().
        The method's implementation is shared,
        but it works with each object's own x1.
        ______________________________________
    */
}
