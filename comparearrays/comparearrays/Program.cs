using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparearrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many numbers should ur array be on?");
            int userLengthOfArray = int.Parse(Console.ReadLine());
            int[] array1 = new int [userLengthOfArray];

            int[] array2 = new int[userLengthOfArray];

            Console.WriteLine("Which number should be in ur first array seperate by space");
            array1 = StringToIntArray(Console.ReadLine());


            Console.WriteLine("which numbers should be in ur second array seperate by space");

            array2 = StringToIntArray(Console.ReadLine());
            byte count = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        count++;
                    }
                }
            }


            Console.Clear();
            Console.Write("Ur choose in array1 the numbers: ");
            Console.Write(string.Join(", ", array1));
            Console.WriteLine();
            Console.Write("U Have chosen in array2 the numbers:  ");
            Console.Write(string.Join(", ", array2));
            Console.WriteLine();
            Console.WriteLine("U had {0} equal elements in ur two chosen arrays", count);

            
        




            
        

            



        }

        static int[] StringToIntArray(string array)
        {

            int[] arrayFromString = array.Split(' ')
                                         .Select(element => int.Parse(element))
                                         .ToArray();
            return arrayFromString;
        }

    }
}
