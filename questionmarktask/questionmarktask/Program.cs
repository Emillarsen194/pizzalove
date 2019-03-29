using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionmarktask
{
    class Program
    {
        static void Main(string[] args)
        {
            string questionMark = "?";

            string firstrow = questionMark + questionMark + questionMark + questionMark + questionMark;
            string lastrow  = questionMark + questionMark + questionMark + questionMark + questionMark;
            string middlerow = questionMark + "   " + questionMark;

            Console.WriteLine(firstrow);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(middlerow);
            }

            Console.WriteLine(lastrow);
            
        }
    }
}
