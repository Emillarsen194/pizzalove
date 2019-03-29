using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numbers = new Random();

            int[] winningCuponNumbers = new int[7]; // winning cupons numbers 
            int[] userCupon = new int[7]; // user cupons numbers array 
            int equalNumbers = 0; // counts how many equal numbers we have in our for loop

            for (int i = 0; i < winningCuponNumbers.Length; i++) //making our winninhg cupon with 7 random numbers from 1 - 20
            {
                int winningCupon = numbers.Next(1, 20);
                winningCuponNumbers[i] = winningCupon;
               
            }

            for (int i = 0; i < userCupon.Length; i++) // making the user cupon that the user insert the numbers him self
            {
                Console.WriteLine("Indtast dit " + (i+1) + " nummer på din kupon");
                userCupon[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
              
            for (int i = 0; i < winningCuponNumbers.Length; i++)  // checking how many numbers is equal 
            {
                for (int j = 0; j < userCupon.Length; j++)
                {
                    if (userCupon[i] == winningCuponNumbers[j])
                    {
                        equalNumbers++;
                    }
                }
            }


            Console.WriteLine("Kuponens numre: " + string.Join(" ", winningCuponNumbers)); // writing our cupons so user can compare them self numbers are seperated with space
            Console.WriteLine("Din kupons numre: " + string.Join(" ", userCupon));

       
            switch (equalNumbers) // switch case to pay out the prices 
            {
                case 1:
                    Console.WriteLine("du have " + equalNumbers + " rigtige du vandt ikke noget fordi du kun havde et rigtigt tal bedre held næste gang");
                    break;
                case 2:
                    Console.WriteLine("Tilykke du havde " + equalNumbers + " rigtige du vandt 100 Kroner");
                    break;
                case 3:
                    Console.WriteLine("Tilykke du havde " + equalNumbers + " rigtige du vandt 250 Kroner");
                    break;
                case 4:
                    Console.WriteLine("Tilykke du havde " + equalNumbers + " rigtige du vandt 500 Kroner");
                    break;
                case 5:
                    Console.WriteLine("Tilykke du havde " + equalNumbers + " rigtige du vandt 1250 Kroner");
                    break;
                case 6:
                    Console.WriteLine("Tilykke du havde " + equalNumbers + " rigtige du vandt 5000 Kroner");
                    break;
                case 7:
                    Console.WriteLine("Jaaackpot du havde " + equalNumbers + " rigtige du vandt 100,000 Kroner");
                    break;
            }




            


        }
    }
}
