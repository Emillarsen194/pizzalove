using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg5arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5]; // making our 2d array 5*5 = 25 elements 5 rows and 5 colums 
            int fillNumbers = 0; //filling our numbers 

            for (int row = 0; row < array.GetLength(0); row++) //get array length of rows
            {
                for (int col = 0; col < array.GetLength(1); col++) //get array length of colums 
                {
                    fillNumbers++; //fill numbers 
                    
                    array[row, col] = fillNumbers; //fills rows and colums
                }
            }

            for (int row = 0; row < array.GetLength(0); row++) //prints our 2d array
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write("{0} ", array[row, col]);
                }

                Console.WriteLine();
            }

        }
    }
}
