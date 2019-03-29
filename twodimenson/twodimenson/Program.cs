using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twodimenson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("\nColumns: ");
            int columns = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));

            int[,] array = new int[rows, columns];

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.WriteLine("array[{0},{1}] = ", row, col);
                    array[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                  Console.Write("Array[{0},{1}] = {2}", row, col, array[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
