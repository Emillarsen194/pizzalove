using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg4
{
    class Program
    {
        static void Main(string[] args)
        {
            logic.OneToTen();
            Console.WriteLine();

            logic.ReversedForLoop();

            Console.WriteLine("Input x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(logic.Xloop(x));
        }
    }
}
