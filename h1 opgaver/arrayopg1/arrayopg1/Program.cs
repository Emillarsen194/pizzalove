using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayopg1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = { "emil", "thor", "mia", "ole", "torben" };
            string[] passWords = { "mug", "password", "cisco", "ost", "kat", };
            bool isUserNameCorrect = false;
            bool isPassWordCorrect = false;
            int triesBack = 3;
            
         
                Console.WriteLine("Hvad er dit brugernavn");
                string getUserName = Console.ReadLine().ToLower();


               // Console.WriteLine("Hvad er dit kodeord");
               // string getPassWord = Console.ReadLine();

                for (int i = 0; i < userNames.Length; i++)
                {

      
                    if (getUserName == userNames[i])
                    {
                    isUserNameCorrect = true;
                    Console.Clear();
                    Console.WriteLine("welcome {0}", userNames[i]);
                    
                    i = + 4;
                            while (triesBack > 0)
                            {

                        if (isPassWordCorrect == true)
                        {
                            break;
                        }

                        Console.WriteLine("what is ur password:");
                        string getPassWord = Console.ReadLine();


                        if (isUserNameCorrect == true)
                    {
                            for (int j = 0; j < passWords.Length; j++)
                            {
                                for (int h = 0; h < passWords.Length; h++)
                                {

                                    if (getPassWord == passWords[j] && userNames[j] == passWords[j])
                                    {
                                        Console.WriteLine("access granted");
                                        h = +4;

                                        isPassWordCorrect = true;

                                    }
                                }
                            
                   

                                else if (getPassWord != passWords[j])
                                {
                                    j = +4;
                                    triesBack--;
                                    Console.WriteLine("forkert kodeord prøv igen du har antal forsøg tilbage: {0}", triesBack);
                                   
                                }

                                if (triesBack == 0)
                                {
                                    
                                    Console.WriteLine("du er blevet låst ude af systemet {0}", userNames[i]);
                                    break;
                                    
                                    
                                }
                            }
                        }

                    }

                    }

           
            else if (getUserName != userNames[i])
            {

                    Console.Clear();
                    Console.WriteLine("adgang nægtet");
            }

                   
                }



         
            

        }
        }
    }

