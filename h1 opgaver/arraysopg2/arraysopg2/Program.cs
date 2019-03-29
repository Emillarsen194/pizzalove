using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysopg2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isBoyNameFound = false; // boolean to check if name is found on search 

            // string array with 20 boy names
            string[] boyNames = { "william", "oliver", "noah", "emil", "victor", "magnus",
                                  "fredrik", "mikkel", "lucas", "alexander", "oscar", "mathias",
                                  "sebastian", "malthe", "elias", "christian", "mads", "gustav", "villads", "tobias"};
            Array.Sort(boyNames); // sorting the array from a - z 

            foreach (string item in boyNames) // writeing our boynames
            {
                Console.WriteLine(item);
            }
            while (!isBoyNameFound == true) // while boynames is not found keep running so we can keep searching
            {


            Console.WriteLine("Hvilke navn vil du søge efter");
            string findBoyName = Console.ReadLine(); // what boy name do u want to find

            for (int i = 0; i < boyNames.Length; i++) 
            {
                if (findBoyName == boyNames[i]) // if the searched name is in our array boynamefound = true and breaks while loop
                {
                    Console.WriteLine("Navnet blev fundet {0}", boyNames[i]);
                    isBoyNameFound = true;
                }
            }

            if (isBoyNameFound == false) // if boy name is not found keep running code cause isboynamefound still false
            {
                Console.WriteLine("Navnet blev ikke fundet");
            }
              
            }

            Console.ReadKey();
                




        }
    }
}
