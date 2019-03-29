using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valutaomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = 0.15; //først skaffer vi hvad en krone er i de forskellige valutaer
            double gbp = 0.12;
            double euro = 0.13;
            double sek = 1.37;

            Console.WriteLine("indtast hvor mange Danskekroner du vil omregne"); //finder ud af hvor mange danske kroner vi vil omregne
            double dkk = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} Danskekroner til usd er {1} usd", dkk, (dkk * usd)); // her ud regner vi alle valutaer fra vores indtastede kronebeløb
            Console.WriteLine("{0} Danskekroner til gbp er {1} gbp", dkk, (dkk * gbp));
            Console.WriteLine("{0} Danskekroner til euro er {1} euro", dkk, (dkk * euro));
            Console.WriteLine("{0} Danskekroner til Svenskekroner er {1} Svenskekroner", dkk, (dkk * sek));

            

            Console.WriteLine();
            

            Console.ReadKey();
        }
    }
}
