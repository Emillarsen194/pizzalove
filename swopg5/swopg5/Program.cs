using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swopg5
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = "Starwars two";
            
            File.WriteAllText(@".\Movies.txt", "Star wars\r\nThe Empire strikes back\r\nReturn Of The Jedi\r\n");

            while (true)
            {
                string addMovie = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(
                new FileStream(@".\Movies.txt", FileMode.Append)))
            {
                writer.WriteLine(addMovie);
            };

            using (var reader = new StreamReader(
                new FileStream(@".\Movies.txt", FileMode.Open)))
            {
                 
            };
              
            }



        }
    }
}
