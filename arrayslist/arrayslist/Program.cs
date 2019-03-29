using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayslist
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("how long should the array be?: ");
            //int lengthOfArray = int.Parse(Console.ReadLine());
            //Console.WriteLine(new string('-', 40));
            //int[] intArray = new int[lengthOfArray];

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    intArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine(new string('-', 40));

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine(intArray[i]);
            //}
            //Console.WriteLine(new string('-', 40));

            //foreach (var item in intArray)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(new string('-', 40));

            //Console.WriteLine(string.Join(" ", intArray));

            //int number = 5;

            //int secondNumber = number;

            //number++;

            //Console.WriteLine(number);
            //Console.WriteLine(secondNumber);

            //int[] array = { 1, 2, 3 };
            //int[] secondArray = array;

            //array[0] = 10;
            //Console.WriteLine(array[0]);
            //Console.WriteLine(secondArray[0]);

            //int[] array = { 1, 2, 3, 4 };
            //int[] tempArray = new int[array.Length];
            //Console.WriteLine(string.Join(", ", array));
            //Console.WriteLine(string.Join(", ", tempArray));

            //Console.WriteLine(new string('-', 40 ));

            //for (int i = 0; i < array.Length; i++)
            //{
            //    tempArray[array.Length - 1 - i] = array[i];
            //}

            //array = (int[])tempArray.Clone();
            //Console.WriteLine(string.Join(", ", array));
            //Console.WriteLine(string.Join(", ", tempArray));

            //Array.Reverse(array);
            //Console.WriteLine(string.Join(", ", array));

            // BUBBLE SORTED ARRAY 
            //int[] array = { 5, 3, 78, 1, -1 };
            //int temp = 0; 
            //Console.WriteLine(string.Join(", ", array));
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array.Length - 1; j++)
            //    {
            //        if (array[j] > array[j + 1])
            //        {
            //            temp = array[j + 1];
            //            array[j + 1] = array[j];
            //            array[j] = temp;
            //        }
            //    }
            //}

            //input array one line

            //    int[] intArray = StringToIntArray(Console.ReadLine());

            //    for (int i = 0; i < intArray.Length; i++)
            //    {
            //        Console.WriteLine(intArray[i]);
            //    }



            //} method 
            //static int[] StringToIntArray(string array)
            //    {
            //            int[] intArray = array.Split(' ').Select(elements => int.Parse(elements)).ToArray();

            //            return intArray;

            //        }

            // end input array one line

            List<int> intList = new List<int>();

            intList.Add(5);
            intList.Add(5);
            intList.Add(5);
            intList.Add(5);
            intList.Add(5);
            intList.Add(5);
            intList.Add(5);
            intList.Add(5);

            //print list
            intList[4] = 4;
            Console.WriteLine(String.Join(", ", intList));

            //change to be 10 in thrid place 
            intList[3] = 10;

            //print it again
            Console.WriteLine(string.Join(", ", intList));


            // empty a list 
            // intList.Clear(); 

            // remove a specific number
            intList.RemoveAt(3);
            Console.WriteLine(string.Join(", ", intList));

            // removes the number 4
            intList.Remove(4);

            Console.WriteLine(string.Join(", ", intList));

            Console.WriteLine(intList.Count());



        }

    }
}
