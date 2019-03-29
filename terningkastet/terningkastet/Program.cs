using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terningkastet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //here we make our random
            int diceThrow = random.Next(1, 7); //here we make our random int that goes from 1-6 cause u have to minus 1 from 7

            switch (diceThrow) //switch our random int
            {
                // if random int is 1 do that
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("du slog en etter");
                    break;
                case 2: // if random int is 2 do this
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("du slog en to'er");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("du slog en tre'r");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("du slog en fire");
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("du slog en femmer");
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("du slog en sekser");
                    break;

            }

            Console.ResetColor(); // reset our console color so not all text are the color
        }
    }
}
