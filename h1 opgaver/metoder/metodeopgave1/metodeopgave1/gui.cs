using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodeopgave1
{
    class gui
    {
        static void Main(string[] args)
        {
            Console.Write("indtast dit første tal: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("indtast dit andet tal: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(firstNumber + " gange med " + secondNumber + " = " + logic.Multiply(firstNumber, secondNumber)); // multiply metod
            Console.WriteLine();
            Console.WriteLine(firstNumber + " divideret med " + secondNumber + " = " + logic.Divison(firstNumber, secondNumber)); // dividson method
            Console.WriteLine();
            Console.WriteLine(secondNumber + " går op i " + firstNumber + ": " + logic.Modulus(firstNumber, secondNumber) + " gange"); // modulus method
            Console.WriteLine();
            Console.WriteLine(firstNumber + " opløftede med " + secondNumber + " = " + logic.PowerOf(firstNumber, secondNumber)); // pow method

        }
    }
}
