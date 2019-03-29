using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camilla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast din alder:");
            int age = int.Parse(Console.ReadLine()); // get age
            Console.Clear(); //clear it so we can get new text and they dont stack

            Console.WriteLine("indtast dit navn:"); // get name 
            string pigen = Console.ReadLine();
            Console.Clear(); // clear again

            if (age < 3)
            {
                Console.WriteLine("{0} du må gå med ble", pigen);
            }

            else if (age >= 3 && age < 15) // if age is bigger than or 3 and age is less than 15 
            {
                Console.WriteLine("{0} du må ingenting", pigen);
            }

            else if (age >= 15 && age < 18) // else if age is more or the same as 15 and age is under 18 
            {
                Console.WriteLine("{0}, du må drikke", pigen);
            }

            else if (age >= 18) // if age is more or the same as 18 
            {
                Console.WriteLine("{0} Du må stemme og køre bil", pigen);
            }
            Console.ReadLine();
            
        }
    }
}
