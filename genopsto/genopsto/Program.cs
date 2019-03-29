using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace genopsto
{
    class Program
    {
        static void Main(string[] args)
        {
      

            string currency = "M";
            int sum = 1000;




            while (sum >= 0)
            {








                Random rng = new Random();
                int playerRandom = rng.Next(1, 100);
                int playerTwoRnd = rng.Next(1, 100); 




                Console.WriteLine("How much will u bet in diceduel");

                int howMuch = int.Parse(Console.ReadLine());

                if (playerRandom >= 52 && howMuch <= sum)
                {
                    sum = WonGame(howMuch, currency, playerRandom, sum);
                }


                if (playerRandom <= 51 && howMuch <= sum)
                {
                    sum = LostGame(howMuch, currency, playerRandom, sum);
                }


            }
        }






    
        public static int LostGame(int howMuch, string currency, int playerRandom, int sum)
        {
            sum = sum - howMuch;
            Console.Clear();
            Console.WriteLine("U rolled {0} on the dice", playerRandom);
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("U LOST {0}{1}", howMuch, currency);
            Console.ResetColor();
            Console.WriteLine("You got {0}{1} Left", sum, currency);

            return sum;
        }

        public static int WonGame(int howMuch, string currency, int playerRandom, int sum)
        {
            sum = howMuch + sum;
            Console.Clear();
            Console.WriteLine("U rolled {0} on the dice", playerRandom);
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("U Won {0}{1}", howMuch, currency);
            Console.ResetColor();
            Console.WriteLine("You got {0}{1} Left in the Bank", sum, currency);
            return sum;

        }
    }
}











