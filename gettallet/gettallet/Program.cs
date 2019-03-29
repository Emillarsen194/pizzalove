using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gettallet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("indtast et nummer mellem 1-1000 for at gætte tallet du har evigt forsøg");
            Random r = new Random();
            int rng = r.Next(1, 1000);
            int tallet = 0;
            int count = tallet;
            while (tallet != rng)
            {
            tallet = int.Parse(Console.ReadLine());

                count++;

                if (tallet < rng)
                {
                    Console.WriteLine("tallet skal være højre du intastede:" + tallet);
                    Console.WriteLine("du har brugt antal forsøg: " + count);
                }

                else if (tallet > rng)
                {
                    Console.WriteLine("tallet skal være lavere du intastede:" + tallet);
                    Console.WriteLine("du har brugt antal forsøg: " + count);
                }

                else if (tallet == rng)
                {
                    if (count < 15)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Hip Hip Hurra du har kun brugt {0} forsøg du super god", count);
                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed; 
                        Console.WriteLine("super dårligt du har brugt {0} forsøg du er virkelig ikke særlig klog ", count);
                    }
                }
                
            }

            
            

        }
    }
}
