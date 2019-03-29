using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace løkker
{
    class Program
    {
        static void Main(string[] args) 
        {
             for (int i = 0; i <= 99; i++) // our for int that counts from 0 - 99
             {
                 if (i < 50) //if i is smaller than 50 cw i
                 {
                     Console.WriteLine(i);
                 }
                 Console.WriteLine(i); // counts from 1-99
             }

            byte j = 0; // our variable that starts from 0 that we can use in our while


             while (j < 99) //while j is smaller than 99 
             {
                 j++; //add 1 to j every time it runs
                 Console.WriteLine(j);
             }

            for (int i = 99; i > 0; i--) // counts backwards 
            {
                Console.WriteLine(i);
            }
        }
    }
}
