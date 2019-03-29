using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Hvad er dit navn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hvad er din alder");
            int age = int.Parse(Console.ReadLine());

            logic.LegalAge(name, age);
        }
    }
}
