using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("hvad vil du gerne have oversat til morsekode");
            string textToMorse = Console.ReadLine(); //get the text they want translated to morsecode
            char[] morseArray = textToMorse.ToCharArray(); //makes the string into a char array to be easier to loop the length of the string and caseswitch

            StringBuilder morseCode = new StringBuilder(); //string builder makes u able to change strings as when strings are created u cannot change them 

            for (int i = 0; i < morseArray.Length; i++) // for as long as i is smaller than our array length
            {
               
            switch (morseArray[i]) //switch our morse array starts from 0. 
            {
                    case 'a':
                        morseCode.Append(".-");
                        break;
                    case 'b':
                        morseCode.Append("-...");
                        break;
                    case 'c':
                        morseCode.Append("-.-.");
                        break;
                    case 'd':
                        morseCode.Append("-..");
                        break;
                    case 'e':
                        morseCode.Append(".");
                        break;
                    case 'f':
                        morseCode.Append("..-");
                        break;
                    case 'g':
                        morseCode.Append("--.");
                        break;
                    case 'h':
                        morseCode.Append(". ...");
                        break;
                    case 'i':
                        morseCode.Append("..");
                        break;
                    case 'j':
                        morseCode.Append(".---");
                        break;
                    case 'k':
                        morseCode.Append("-.-");
                        break;
                    case 'l':
                        morseCode.Append(".-..");
                        break;
                    case 'm':
                        morseCode.Append("--");
                        break;
                    case 'n':
                        morseCode.Append("-.");
                        break;
                    case 'o':
                        morseCode.Append("---");
                        break;
                    case 'p':
                        morseCode.Append(".--.");
                        break;
                    case 'q':
                        morseCode.Append("--.-");
                        break;
                    case 'r':
                        morseCode.Append(".-.");
                        break;
                    case 's':
                        morseCode.Append(". ..");
                        break;
                    case 't':
                        morseCode.Append("-");
                        break;
                    case 'u':
                        morseCode.Append("..-");
                        break;
                    case 'v':
                        morseCode.Append("...-");
                        break;
                    case 'w':
                        morseCode.Append(".--");
                        break;
                    case 'x':
                        morseCode.Append("-..-");
                        break;
                    case 'y':
                        morseCode.Append("-.--");
                        break;
                    case 'z':
                        morseCode.Append("--..");
                        break;
                    case 'æ':
                        morseCode.Append(".-.-");
                        break;
                    case 'ø':
                        morseCode.Append("---.");
                        break;
                    case 'å':
                        morseCode.Append(".--.-");
                        break;
                    


                }
                
                Console.Write(morseCode); // writes out our morsecode from text
            }
            Console.ReadKey();
            }
        }
    }
}