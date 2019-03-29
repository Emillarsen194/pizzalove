using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg10
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = Logic.MakeRandomNumber();
            int tries = 0;
            bool gameOver = false;





            Console.WriteLine("gæt tallet mellem 1-1000");
            while (!gameOver == true)
            {
                Console.WriteLine("hvad er dit gæt: ");

                int guess = int.Parse(Console.ReadLine());

                Console.WriteLine(Logic.GuessTheNumber(guess, secretNumber));

                tries++;

                if (guess == secretNumber)
                {
                    gameOver = true;
                }
                    
            }

           
                
                

            Console.WriteLine(tries);
        }
    }
}
