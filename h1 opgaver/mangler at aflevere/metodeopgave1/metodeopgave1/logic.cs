using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodeopgave1
{
    class logic
    {

       
       public static double Multiply(double numberOne, double numberTwo) // our method for multiplying 2 numbers from userinput or static
        {
            double multiplyer = numberOne * numberTwo;
            return multiplyer;
        }

        public static double Divison(double numberOne, double numberTwo) // divison method
        {
            double divider = numberOne / numberTwo;
            return divider;
        }

        public static double Modulus(double numberOne, double numberTwo) // find out how many times a number goes into another and modulus getting the reminder
        {
    
            double howmany = numberOne / numberTwo;
            double remainder = numberOne % numberTwo;
            

            return howmany + remainder;
        } 

        public static double PowerOf(double numberOne, double numberTwo) // powerof method just stealing another method 
        {
            double power = Math.Pow(numberOne, numberTwo);
            return power;
        }

            
    }
}
