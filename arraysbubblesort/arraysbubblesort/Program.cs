using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysbubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = new int [100]; // making our array that can hold 100 elements 
            Random random = new Random(); // making a random 

            for (int i = 0; i < randomArray.Length; i++)
            {
                int randomNumbersFill = random.Next(1, 1000); // making our random int between 1 and 1000 random number
                randomArray[i] = randomNumbersFill; // filling our 100 elements with random numbers

               
            }

            for (int i = 0; i <= randomArray.Length - 1; i++) // sorting our random array with bubblesort 
            {
                for (int j = 0; j < (randomArray.Length - 1); j++)
                {
                    if (randomArray[j] > randomArray[j + 1]) 
                    {
                        int tmp = randomArray[j + 1];
                        randomArray[j + 1] = randomArray[j];
                        randomArray[j] = tmp;
                    }
                }
            }

            Array.Reverse(randomArray); // reversing our array

            foreach (int item in randomArray) // writing out our array
            {
                Console.WriteLine(item);
            }



        }
    }
}
