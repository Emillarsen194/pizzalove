using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg4
{
    class logic
    {
        public static int OneToTen() //looping the numbers 1-10
        {
            int count = 0;
            for (int i = 1; i <= 10; i++)
            {
                count++;
                Console.WriteLine(count);
            }

            return count;
        }

        public static int ReversedForLoop() // reversing the numbers 1-10
        {
            int count = 11;

            for (int i = 10; i > 0; i--)
            {
                count--;
                Console.WriteLine(count);
            }
            return count;
        }

        public static int Xloop(int x) // getting x and making it into sum x + 32 - 297 = sum
        {
            int sum = 0;
            for (int i = 0; i < 1; i++)
            {
                sum = x + 32 - 297;
            }

            return sum;
        }
    }
}
