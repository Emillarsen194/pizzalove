using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listeopg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20}; // making the list numbers that contains our numbers

            

            for (int i = 0; i < numbers.Count; i++) // we use count with list to see the length of the list 
            {
                
                if (numbers[i] % 3 == 0) // if one of our numbers in our list modulus 3 is the same as 0 3 goes up in the number
                {
                    numbers.Remove(numbers[i]); // then remove the numbers we found
                }
            }

             numbers.Insert(2, 17); // insert 17 on the 3 place in the list

            foreach (int item in numbers) // printing our list
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(); // fill so i can figure out the numbers
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("               omvendt liste                    ");
            Console.WriteLine("------------------------------------------------");
            
            List<int> reversedNumbers = new List<int>(numbers); // new list that takes the old list in the collection

            reversedNumbers.Reverse(); // .reverse reverses our list 

            foreach (int item in reversedNumbers) // printing our new list
            {
                Console.WriteLine(item);
            }

     
        }
    }
}
