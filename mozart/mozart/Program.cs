using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace mozart
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mFileSounds = new string[177];
            double[,] soundToplay = new double[17, 17];
            Random randomFillCol = new Random();
            Random randomThrow = new Random();
            SoundPlayer sp = new SoundPlayer();
            double getRowNumbers = 0;
          
            



      
            
            double fillNumbers = 0; //filling our numbers 
          
            for (int row = 1; row < soundToplay.GetLength(0); row++) //get array length of rows
            {
                    getRowNumbers++;
                    double firstnumbers = soundToplay[0, row] = getRowNumbers;
                for (int col = 0; col < soundToplay.GetLength(1); col++) //get array length of colums 
                {
                    fillNumbers++; //fill numbers 
                    double randomNumberFillcol = randomFillCol.Next(1, 176);
                    soundToplay[row, col] = randomNumberFillcol;  //fills rows and colums
                    

                }
               
            }

            for (int i = 0; i < soundToplay.GetLength(0); i++) //writing out our numbers
            {
                for (int j = 0; j < soundToplay.GetLength(1); j++)
                {
                    Console.Write("{0} ", soundToplay[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 1; i < soundToplay.GetLength(0); i++) // deciding which file to play with a random dicethrow 
            {
                int dicethrow1 = randomThrow.Next(1, 16);
                int dicethrow2 = randomThrow.Next(1, 16);
                mFileSounds[i] = @"C:\Users\emil8398\Desktop\Wave\M" + soundToplay[dicethrow1, dicethrow2] + ".wav";
                //Console.WriteLine(mFileSounds[i]);
            }

         
            for (int i = 1; i < mFileSounds.Length; i++) // playing our sounds
            {

            sp.SoundLocation = mFileSounds[i]; // locations for our file 
            sp.Load(); 
            sp.PlaySync();
            }

    
        }
    }
}
