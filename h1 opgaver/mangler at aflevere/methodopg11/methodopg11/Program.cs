using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 16;
            int numberTwo = 5;

            // 11.1 return the sum 
            Console.WriteLine(Logic.Sum(numberOne, numberTwo));
            Console.WriteLine();

            // 11.2 return two numbers divided by each other

            Console.WriteLine(Logic.Divided(numberOne, numberTwo));
            Console.WriteLine();

            // 11.3 
            Console.WriteLine(Logic.Modulus(numberOne, numberTwo));
            Console.WriteLine();

            //11.4

            List<int> liste = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine(liste.Max());

            Console.WriteLine(Logic.BiggestElement(liste));


           Console.WriteLine(Logic.BiggestElement(liste));

            
            
            
        }
    }
}
