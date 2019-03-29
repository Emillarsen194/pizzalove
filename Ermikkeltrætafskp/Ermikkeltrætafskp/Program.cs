using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ermikkeltrætafskp
{
    class Program
    {
        static void Main(string[] args)
        {
            int retardo = 1; 
            Console.WriteLine("Hvad er dit navn:");
            string navn = Console.ReadLine();
            Console.WriteLine("Er du træt af skp {0}?", navn);
            string mikkel = Console.ReadLine();

            if (mikkel == "ja")
            {
                Console.WriteLine("du kan bare flexe");
            }

            else if (mikkel == "nej")
            {
                Console.WriteLine("det også nogle lange dage");
            }

           
            

            
            else
            {
                while (true)
                {
                    retardo++;
                    Console.WriteLine("du ligner en retardo{0} gange", retardo );
                    if (retardo == 1000)
                    {
                        Thread.Sleep(5000);
                    }
                }
                    
                }
           

            }
        }
    }

