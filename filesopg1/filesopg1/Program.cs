using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filesopg1
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@".\StarWars.txt", "Han skød først");

            // string content = File.ReadAllText(@".\StarWars.txt"); reads txt from starwars file. 
            // Console.WriteLine(content);

           // File.Delete(@".\StarWars.txt"); //Deletes a file 

        }
    }
}
