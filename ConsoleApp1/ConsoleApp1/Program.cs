using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int posx = 0;
            string ball = "(~)";
            int posy = 0;
            Random r = new Random();
            int[] numbers = {1, 2, 3, 5, 4, 6 };
            //Console.WriteLine(ball);
            int ballands = r.Next(0,6);
            //Console.Write(string.Join("( ball   ) ", numbers));
            Console.WriteLine();


            //while (ballands == numbers[i])
            //{


            //    if (ballands == 1)
            //    {
            //        ballands++;
            //        Console.WriteLine("{0} {1}", ball, numbers[0]);

            //    }
            //Console.WriteLine("im out");
            //}

           int count = 0;
            for (int i = 0; i < 10; i++)
            {
                count++;

                Console.Clear();
                switch (count)
                {
                    case 1:
                        Console.Write(new string(' ', i)); Console.Write(ball); ;
                        break;
                    case 2:
                        Console.Write("  (--)");
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("    (--)");
                        break;
                    case 4:
                        Console.WriteLine("    (--)");
                        break;
                    case 5:
                        Console.Write("     (--)");
                        break;
                    case 6:
                        Console.Write("      (--)");
                        break;
                    case 7:
                        Console.Write("       (--)");
                        break;
                    case 8:
                        Console.Write("        (--)");
                        break;
                    case 9:
                        Console.Write("         (--)");
                        break;
                    case 10:
                        Console.Write("          (--)");
                        break;
                }
                        Thread.Sleep(10);


            }

            for (int j = 0; j < 1000000; j++)
            {
                for (int b = 0; b < 100000; b++)
                {

                    j++;

                    Console.Write(new string(' ', b)); Console.Write(ball); ;
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                j++;
                
                Console.Write(new string(' ', j)); Console.Write(ball); ;
                Thread.Sleep(10);
            }

   

     

            Console.Read();

        }
    }
}
