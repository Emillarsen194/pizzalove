using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int tiTilTyve = int.Parse(Console.ReadLine());
        
            if (tiTilTyve >= 20)
            {
                Console.WriteLine("Please input a number between 1-20");
            }
            else
            {


                switch (tiTilTyve)
                {
                    case 1:
                        Console.WriteLine("En");
                        break;
                    case 2:
                        Console.WriteLine("To");
                        break;
                    case 3:
                        Console.WriteLine("Tre");
                        break;
                    case 4:
                        Console.WriteLine("Fire");
                        break;
                    case 5:
                        Console.WriteLine("Fem");
                        break;
                    case 6:
                        Console.WriteLine("Seks");
                        break;
                    case 7:
                        Console.WriteLine("Syv");
                        break;
                    case 8:
                        Console.WriteLine("Otte");
                        break;
                    case 9:
                        Console.WriteLine("Ni");
                        break;
                    case 10:
                        Console.WriteLine("Ti");
                        break;
                    case 11:
                        Console.WriteLine("Elleve");
                        break;
                    case 12:
                        Console.WriteLine("Tolv");
                        break;
                    case 13:
                        Console.WriteLine("Tretten");
                        break;
                    case 14:
                        Console.WriteLine("Fjorten");
                        break;
                    case 15:
                        Console.WriteLine("Femten");
                        break;
                    case 16:
                        Console.WriteLine("Seksten");
                        break;
                    case 17:
                        Console.WriteLine("Sytten");
                        break;
                    case 18:
                        Console.WriteLine("Atten");
                        break;
                    case 19:
                        Console.WriteLine("Nitten");
                        break;
                    case 20:
                        Console.WriteLine("Tyve");
                        break;




            
                }
            }
        }
    }
}
