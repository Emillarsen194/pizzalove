using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int zero = 0;


            //Console.WriteLine("dit første nummer:");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("dit anden nummer:");
            //int endNumber = int.Parse(Console.ReadLine());


            //while (firstNumber < endNumber)
            //{
            //    if (firstNumber < endNumber)
            //    {
            //        firstNumber++;
            //        Console.WriteLine(firstNumber);
            //    }
            //
            //    else if (firstNumber > endNumber)
            //    {
            //        endNumber++;
            //        Console.WriteLine(endNumber);
            //    }
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("The for loop was executed for {0} times!", i);
            //}

            //int[] array = { 1, 2, 3 };

            //for (int i = array.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //string[] ourStringCollection = { "collection", "one", "two", "i am the 4th thing in the array" };

            //foreach (var item in ourStringCollection)
            //{
            //Console.WriteLine(item);
            //}

            int n = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= n; rows++)
            {
                for (int number = 1; number <= rows; number++)
                {
                    Console.Write(number);

                }
                Console.WriteLine();
            }
           
            


        }
    }
}
