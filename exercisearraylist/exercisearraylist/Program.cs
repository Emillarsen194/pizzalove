using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisearraylist
{
    class Program
    {

        static void Main(string[] args)

        {  //program that multiplies arrays
            int[] array = new int [21];
            

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5; 
            }

            Console.WriteLine(string.Join(" ", array));




        }
    }
}
