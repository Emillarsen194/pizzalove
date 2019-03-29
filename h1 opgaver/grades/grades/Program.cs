using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] grades = new float[2, 10]; //making our 2 dimensional array with 2 rows and 10 colums in each 20 inputs needed 2*10 = 20


            for (int row = 0; row < grades.GetLength(0); row++) //getlength for rows 
            {
                for (int col = 0; col < grades.GetLength(1); col++) //getlength for cols
                {
                    Console.Write("[indtast karaktere for række {0},{1} kulonne] = ", row+1, col+1); // making our user input the number en rows and coloums 
                    grades[row, col] = int.Parse((Console.ReadLine()));
                }
            }

            for (int row = 0; row < grades.GetLength(0); row++) // writing the grades out on the console
            {
                for (int col = 0; col < grades.GetLength(1); col++)
                {
                    Console.Write("{2} ", row, col, grades[row, col]);
                    

                }

                Console.WriteLine();
            }




           

           
            float avg = 0; // our float to calculate the average grades for each class 
            float avg1 = 0;

            for (int row = 0; row < grades.GetLength(0); row++) 
            {
                for (int col = 0; col < grades.GetLength(1); col++)
                {

                    avg = avg + grades[0, col]; 
                    avg1 = avg1 + grades[1, col];
                }
            }
          
            Console.WriteLine("gennemsnittet for række et er: " + avg/20);

            Console.WriteLine("gennemsnittet for række to er: " + avg1/20);



                














        }
    }
}
