using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg11
{
    class Logic
    {
        //11.1 return the sum of 2 numbers
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        //11.2 divide to numbers 

        public static int Divided(int a, int b)
        {
            return a / b;
        }

        // 11.3

        public static double Modulus(double a, double b)
        {
            double howmany = a / b;
            double remainder = a % b;

            return howmany + remainder;
        }

        // 11.4 

        public static List<int> BiggestElement(List<int> A)
        {
            Console.WriteLine(A.Max()); 

            return A;
        }

    }
}
