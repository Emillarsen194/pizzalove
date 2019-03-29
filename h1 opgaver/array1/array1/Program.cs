using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oneToNine = new int [9]; // make our array  

            for (int i = 0; i < oneToNine.Length; i++) // run as long as i is lower than 
            {
                oneToNine[i] = i+1; // fills our array with numbers Onetonine[i] means which index we start with we start from 0 i+1 is so that we start with number one

                if (i == 5) // if i hits 5 we are at index 5 and it is going to print our index 5 and multiply with 2
                {
                    Console.WriteLine(oneToNine[5] * 2);
                }
            }

        
            

            
        }
    }
}
