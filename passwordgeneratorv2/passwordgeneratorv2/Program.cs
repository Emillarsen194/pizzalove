using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordgeneratorv2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Choose the letters u want in ur password to shuffle them");
            string length = Console.ReadLine();
            Console.WriteLine("u choose {0} for u length of ur password press enter to get ur password and enter again if u want new one", length);


            while (true)
            {

                string chars = length;
                var stringChars = new char[length.Length];
                var random = new Random();

                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        for (int i = 0; i < stringChars.Length; i++)
                        {

                            stringChars[i] = chars[random.Next(chars.Length)];

                        }
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Ur password: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(new string('-', stringChars.Length));
                        Console.WriteLine(stringChars);
                        Console.WriteLine(new string('-', stringChars.Length));

                    }

            }

        }
    }

}



