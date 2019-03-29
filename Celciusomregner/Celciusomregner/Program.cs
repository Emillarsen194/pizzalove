using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celciusomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double fahrenheit = 1.8 + 32; //vores Fahrenheit formel
            double Reamur = 0.8; // vores Reamur formel
           double celcius = double.Parse(Console.ReadLine()); // her læser vi vores double vi bruger double så vi kan skrive med kommatal

            Console.WriteLine("Reamur omregnet = {0}", (celcius*Reamur)); //her regner vi vores Reamur ud
            Console.WriteLine("Fahrenheit omregnet = {0}", (celcius*fahrenheit));  // her regner vi vores fahrenheit ud
        }
    }
}
