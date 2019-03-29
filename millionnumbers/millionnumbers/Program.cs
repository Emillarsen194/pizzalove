using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace millionnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();



            for (int i = 0; i < 1000000; i++)
            {

            int millionNumbers = rng.Next(1, 9999);
         
                using (StreamWriter writer = new StreamWriter(
             new FileStream(@".\MillionNumbers.txt", FileMode.Append)))
                {
                    writer.Write(i + ", ");
                    writer.WriteLine(millionNumbers);
                };

            Console.WriteLine(i);
            }

            Console.WriteLine("done");
        }
    }
}
