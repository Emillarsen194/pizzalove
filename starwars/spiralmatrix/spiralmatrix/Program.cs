using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiralmatrix
{
    class Program
    {

        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());


            int multi = 0;


            multi = MultiplyTwoNumbers(numberOne, numberTwo);
            Console.WriteLine(multi);
        }
        //void defines the data type of the method
        static void PrintNames(string firstName, string lastName)
        {
            Console.WriteLine("My first name is {0}", firstName);
            Console.WriteLine("My last name is {0}", lastName);
        }

         static int MultiplyTwoNumbers(int firstNumber, int secondNumber)
        {
            
            
            return firstNumber * secondNumber; 
        }
    }
}
