using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparestrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordOne = Console.ReadLine();
            string wordTwo = Console.ReadLine();

            Console.WriteLine(CompareString(wordOne, wordTwo));
            
        }

        static bool CompareString(string stringOne, string stringTwo)
        {
            bool isEqual = true;

            if (stringOne.Length == stringTwo.Length)
            { 

                for (int i = 0; i < stringOne.Length; i++)
                {
                    if (stringOne[i] != stringTwo[i])
                    {
                        isEqual = false;
                        break;
                    }

                }
                    return isEqual;
            }

            else
            {
                isEqual = false;
                return isEqual;
            }
            }
        }


    }

