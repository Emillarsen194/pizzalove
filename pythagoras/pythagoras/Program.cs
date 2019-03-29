using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtast tal a"); // get number a 
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("indtast tal b"); // get number b
            double b = int.Parse(Console.ReadLine());
           a = Math.Pow(a, 2); // math.pow is power of 2 so it takes a and multiply a with a
           b = Math.Pow(b, 2);
            Console.WriteLine("c = " + (a + b)); // calculates c and prints it

            if (a < b) // if a is smaller than b print a is smaller than b
            {
                Console.WriteLine("a er mindre end b");
            }

            else // if nothing else is true print b are smaller than a 
            {
                Console.WriteLine("b er mindre end a");
            }

            }
    }
}
