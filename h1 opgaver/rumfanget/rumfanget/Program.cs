using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rumfanget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtast højde");  // skaffer vores højde
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("indtast bredde"); // skaffer vores bredde
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("indtast længde"); // skaffer vores længde
            double l = double.Parse(Console.ReadLine());

            Console.WriteLine("dit rumfang af din kasse er = {0}", (h*b*l));

            Console.ReadKey();
        }
    }
}
