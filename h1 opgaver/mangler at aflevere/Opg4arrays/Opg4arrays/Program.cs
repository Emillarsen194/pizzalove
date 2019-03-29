using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg4arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string> { }; // our list that holds nothing before we add to it in console
            while(true) { //making the menu always run

            Console.WriteLine("tilføj nye data = a");
            Console.WriteLine();
            Console.WriteLine("se liste af alt data = d");
            Console.WriteLine();
            Console.WriteLine("søg efter et element = s");
            Console.WriteLine();
            Console.WriteLine("se statistikker = p");
            Console.WriteLine();
            Console.WriteLine("afslut programmet klik escape");
            string whichMenu = Console.ReadLine().ToLower(); // read which menu they want from input 

            if (whichMenu == "a")
            {
                    while (Console.ReadKey(true).Key != ConsoleKey.B) // while key b is not pressed keep running
                    {

                    Console.WriteLine("Hvilke data vil du tilføje:"); // the menu where we can add data 
                    string addData = Console.ReadLine(); // what data do u wanna add
                    data.Add(addData); // adding the data from input

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine(addData + " Er tilføjet til data"); // if data is added print this
                    Console.WriteLine("for at gå tilbage til hovedmenuen klik på b klik på enter for at tilføje mere data"); // how to get back to the menu

                      
                    }
            }


               else if (whichMenu == "d") // see all data menu 
                {
                    Console.Clear();
                    Console.WriteLine("data basen inden holder: "); 
                    foreach (string item in data) // shows what in the database 
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }


                else if (whichMenu == "s") // search in our database menu to see if it contains what u serch for
                {
                    Console.Clear();
                    Console.WriteLine("søg efter et element i databasen: ");  
                    string searchForElement = Console.ReadLine();
                    Console.Clear();
                   bool doesItContain = data.Contains(searchForElement); // if the data contains that were searching for makes doesitcontain true
                    if (doesItContain == true)
                    {
                        Console.WriteLine(searchForElement + " Eksiterer i databasen"); // if it exist then print this
                    }
                    else
                    {
                        Console.WriteLine(searchForElement + " Eksiterer ikke i databasen"); // else print it dosent exist 
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }

                else if (whichMenu == "p") // statistics menu show how many elements in the database
                {
                    Console.Clear();
                    Console.WriteLine("Statistikker");
                    Console.WriteLine();

                    Console.WriteLine("antal elementer i databasen: " + data.Count);

                    Console.WriteLine();
                    Console.WriteLine();
                    
                }
                    
               
            }




        }
    }
}
