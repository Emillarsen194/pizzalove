using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayopg3
{
    class Program
    {
        static void Main(string[] args)
        {
            // making our 2 list with boy names and girl names

            List<string> boyNames = new List<string> { "william", "oliver", "noah", "emil", "victor", "magnus", 
                                  "fredrik", "mikkel", "lucas", "alexander", "oscar", "mathias",
                                  "sebastian", "malthe", "elias", "christian", "mads", "gustav", "villads", "tobias"};

            List<string> girlNames = new List<string> {"emma", "ida", "clara", "laura", "isabella", "sofia", "sofie",
                                                       "anna", "mathilde", "freja", "caroline", "lærke", "maja", "josefine",
                                                       "liva", "alberte", "karla", "victoria", "olivia", "alma"};

     

            bool doneWithAddingNames = false; // our too booleans to check if user is done adding or removing names to the list 
            bool doneWithremovingNames = false;

            while (!doneWithAddingNames == true) // if not done with adding names then keep running
            {

            foreach (string item in boyNames) // printing out our boy names
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Skriv det navn du vil tilføje til listen tast enter når du vil videre");
            string addName = Console.ReadLine().ToLower(); // add the names u want

            if (addName == "")
            {
                doneWithAddingNames = true;
            }

            boyNames.Add(addName);

            Console.WriteLine("Du tilføjede navnet " + addName); // u added the name
                Console.Clear();
            }


            while (!doneWithremovingNames == true) // while not done with removing from our list then keep running
            {

            foreach (string item in boyNames) // printing our list to the console
            {
                Console.WriteLine(item);
            }




            Console.WriteLine();
            Console.WriteLine("Skriv det navn du vil fjerne fra listen når du er færdig med at fjerne fra listen skriv done"); 
                string removeName = Console.ReadLine().ToLower(); // reading what to remove from the list 

                if (removeName == "done")
                {
                    Console.Clear();
                    doneWithremovingNames = true; // if done removing from the list then donewithremovingnames and end the while loop
                }

            boyNames.Remove(removeName);

            Console.WriteLine("du fjernede navnet " + removeName);

            Console.Clear();
            }


            boyNames.AddRange(girlNames); // adds our girlnames to our boy names list 

          
            foreach (string item in boyNames) // printing out both list 
            {
                Console.WriteLine(item);
            }




        }
    }
}
