using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tal
{
    class matematik
    {
        static void Main(string[] args)
        {
            
           

            Console.WriteLine("indtast dit tal");
            int heltal = int.Parse(Console.ReadLine());
            Console.WriteLine("indtast dit andet tal at gange med");
            int heltal2 = int.Parse(Console.ReadLine());

            int gange = heltal * heltal2;
            double divison = heltal / heltal2;
            double nummerOpløftede = Math.Pow(heltal, heltal2);

            Console.WriteLine("dit resultat er:{0}", gange);
            Console.WriteLine("dit divisions resultat er:{0}", divison);
            Console.WriteLine("dit første nummer opløftede med andet nummer er:{0}", nummerOpløftede);

            Console.Read();

            
        }
    }
}
