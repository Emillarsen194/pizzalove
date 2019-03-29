using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

            string[] messages =
            {@"
 _   _   ___   _   _ _____ ___  ___  ___   _   _ 
| | | | / _ \ | \ | |  __ \|  \/  | / _ \ | \ | |
| |_| |/ /_\ \|  \| | |  \/| .  . |/ /_\ \|  \| |
|  _  ||  _  || . ` | | __ | |\/| ||  _  || . ` |
| | | || | | || |\  | |_\ \| |  | || | | || |\  |
\_| |_/\_| |_/\_| \_/\____/\_|  |_/\_| |_/\_| \_/
                                                 
                                                 


                                                                                                      ",

@"__   _______ _       _    _ _____ _   _ 
\ \ / /  _  | | | |  | |  | |_   _| \ | |
 \ V /| | | | | | |  | |  | | | | |  \| |
  \ / | | | | | | |  | |/\| | | | | . ` |
  | | \ \_/ / |_| |  \  /\  /_| |_| |\  |
  \_/  \___/ \___/    \/  \/ \___/\_| \_/
                                              ",

@"  _____          __  __ ______ ______      ________ _____  
 / ____|   /\   |  \/  |  ____/ __ \ \    / /  ____|  __ \ 
| |  __   /  \  | \  / | |__ | |  | \ \  / /| |__  | |__) |
| | |_ | / /\ \ | |\/| |  __|| |  | |\ \/ / |  __| |  _  / 
| |__| |/ ____ \| |  | | |___| |__| | \  /  | |____| | \ \ 
 \_____/_/    \_\_|  |_|______\____/   \/   |______|_|  \_\ 
"


            };
            string[] counting =
            {@"  __ 
/_ |
 | |
 | |
 | |
 |_|
    ",
    @" ___  
|__ \ 
   ) |
  / /
 / / _
| ____ |
      ",
@" ____  
|___ \ 
  __) |
 | __ <
 ___) |
| ____ / ",

@" _  _   
| || |  
| || |_ 
|__   _|
   | |  
   |_|  
        ",
@" _____ 
| ____|
| |__  
|___ \ 
 ___) |
|____/ 
       "


            };
            string[] words = { "mus", "kat", "hund", "agurk", "muskat", "spiderman", "abstinens", "emil", "so", "gris", "dame", "mand", "neger",};


            bool gameOver = false;

            Random rng = new Random();
            int rnd = rng.Next(1, 6);

            string startWord = words[rnd];
            char[] maskStartWord = new string('-', startWord.Length).ToCharArray();
            string currentGuessedcharacter = "";
            string guessedCharacterList = ""; 

            int guessingTries = startWord.Length * 2;
            int violations = 0;
    


            for (int i = counting.Length; i > 0; i--)
            {

                Console.WriteLine(messages[0]);
                Console.WriteLine(counting[i - 1]);
                Thread.Sleep(1000);
                Console.Clear();
                
            }

            while (!gameOver)
            {
                Console.WriteLine("Guess the word:{0}", new string( maskStartWord));
                Console.WriteLine("guessed characters:{0}", guessedCharacterList);
                Console.WriteLine("You have {0} tries left.", guessingTries);
                Console.WriteLine();
                Console.WriteLine("Your next guess is:");

                currentGuessedcharacter = Console.ReadLine();
                guessedCharacterList += currentGuessedcharacter[0] + " , ";

                if (currentGuessedcharacter.Length > 1)
                {
                    if (violations >= 1)
                    {
                        guessingTries--;
                        Console.WriteLine("u wrote more than one character again and lost 2 tries.. do it again and ill fk u up");
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine(" you should only write one character first warning dont do it again");
                    Console.ResetColor();
                    Thread.Sleep(3000);

                    violations++;
                }

            

                if (startWord.Contains(currentGuessedcharacter[0].ToString()))
                {
                        guessingTries++;
                    for (int i = 0; i < startWord.Length; i++)
                    {
                        if (startWord[i] == (currentGuessedcharacter[0]))
                        {
                            maskStartWord[i] = (currentGuessedcharacter[0]);

                        }
                    }
                }

                

                guessingTries--;
                Console.Clear();
                if (guessingTries == 0)
                {
                    gameOver = true;
                    Console.WriteLine(messages[2]);
                    Console.WriteLine("the word was: {0}", startWord);
                    Thread.Sleep(2000);
                }
                else if (!(new string(maskStartWord).Contains("-")))
                {
                    gameOver = true;
                    Console.WriteLine(messages[1]);
                    Console.WriteLine("the word was: {0}", startWord);
                }
                
               
            }

            }
        }

    }
        }
    
