using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lotteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vil du købe en lotteri Kupon? y n?");
            string spille = Console.ReadLine();

            if (spille == "ja" || spille == "y" || spille == "Ja")
            {

                Random rng = new Random();
                int et = rng.Next(1, 20);
                int to = rng.Next(1, 20);
                int tre = rng.Next(1, 20);
                int fire = rng.Next(1, 20);
                int fem = rng.Next(1, 20);
                int seks = rng.Next(1, 20);
                int syv = rng.Next(1, 20);
                int[] intArray = new int[7];
                byte count = 0;
                int[] til = { et, to, tre, fire, fem, seks, syv };
      
                int[] intArrays = new int[7];
                for (int i = 0; i < intArray.Length; i++)
                {


                    Console.WriteLine("Indtast dine lotto tal");
                    intArrays[i] = int.Parse(Console.ReadLine());

                }
                Console.Clear();
                Console.WriteLine(new string('-', 40));
                Console.Write("Dine valgte numre er: ");
                Console.Write(string.Join(" ", intArrays));
                Console.WriteLine();
                Console.WriteLine(new string('-', 40));
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("Kuponens numre er: ");
                Console.WriteLine(string.Join(" ", til));
                Console.WriteLine(new string('-', 40));

                for (int i = 0; i < intArray.Length; i++)
                {
                    for (int j = 0; j < til.Length; j++)
                    {


                        if (intArrays[i] == til[j])
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 40));

                Console.WriteLine(new string('-', 40));

                int moneyPrice = count * 1000;
                double jackpotPrice = count * 2000000;

                if (count <= 6)
                {
                    Console.WriteLine("Du fik rigtige antal tal: " + count + " Du har vundet: " + (moneyPrice.ToString("C2")));
                }

                else if (count == 7)
                {
                    Console.WriteLine("Jackpoi du fik alle tal rigtige " + count + "Du har vundet: " + (jackpotPrice.ToString("C2")));
                }

            }

            else if (spille == "nej")
            {
                Console.WriteLine("hav en god dag");
            }

        }
    }
}
