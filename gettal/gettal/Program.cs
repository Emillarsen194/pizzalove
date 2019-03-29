using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gettal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random(); // making a new random
            int number = num.Next(1, 1000); // making the random between 1 and 1000
            int guess = 0;
            int count = 0;
            Console.WriteLine("gæt nummeret mellem 1 og 1000");
            Console.WriteLine("indtast dit nummer");
            while (number != guess) //while number is not the same as guess run this code below
            {
                count++;
            guess = int.Parse(Console.ReadLine()); // securing our while loop will still run and this is our number when we guess

            

            if (guess < number) // if guess is lower than the number we are trying to guess 
            {
                Console.WriteLine("dit nummer skal være højre");
            }

            else if (guess > number) // if guess is higher than the number that were trying to guess
            {
                Console.WriteLine("dit nummer skal lavere");

            }

            
            else if (guess == number) // if we guess the number 
            {
                    if (count <= 15) // if count is under 15 tries or the same u did good
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("du gættede tallet du brugte kun:{0} forsøg stort tilykke", count);
                        Console.WriteLine("tallet var {0}", number);
                    }
                    else if (count > 15) // if count is more than 15 u did really bad 
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("super dårligt du gættede tallet men brugte {0} forsøg", count);
                        Console.WriteLine("tallet var {0}", number);
                    }

            }

            }

        }
    }
}
