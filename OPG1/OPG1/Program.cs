using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG1
{
    class Program
    {
        static void Main(string[] args)
        {
            // opgave a 

            int a = 16;
            double b = 5.1;

            Console.WriteLine(a+b);

            // opgave b

            int c = a + b; // den oversætter ikke fordi man ikke kan lægge kommatal til en int

            // opgave c 

            double d = a + b; //denne her virker fordi en double kan bruge kommatal samt normale tal

        }
    }
}
