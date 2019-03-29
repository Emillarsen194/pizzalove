using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg3
{
    class logic
    {
        public static void LegalAge(string name, int age)
        {
            
                
            if (age < 3)
            {
                Console.WriteLine(name + ", du må gå med ble");
            }


            else if (age > 3 && age <= 15)
            {
          
                Console.WriteLine(name + ", du må ingenting");
            }

            else if (age > 15 && age < 18)
            {
                Console.WriteLine(name + ", du må drikke");
            }

            else if (age >= 18)
            {
                Console.WriteLine(name + ", du må stemme og køre bil");
            }
        }
    }
}
