using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@".\Droids\Astromech"); //greate directorys   
            Directory.CreateDirectory(@".\Droids\Protocol"); // create directory 

            File.WriteAllText(@".\Droids\Astromech\R2D2.txt", "Beep Bop"); // create text files 
            File.WriteAllText(@".\Droids\Astromech\C3P0.txt", "Sir!"); 

            string[] files = Directory.GetFiles(@".\Droids", "*.txt", SearchOption.AllDirectories); 

            foreach (string file in files)
            {
                Console.WriteLine(files);
            }



           // Directory.Delete(@".\Droids", true);
        }
    }
}
