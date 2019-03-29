using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[5] { "emil", "larsen", "thor", "mia", "ole" };  // our usernames array holding 5 usernames
            string[] passWords = new string[5] { "kode1", "kode2", "kode3", "kode4", "kode5" }; // passwords array holding 5 passwords

            
            bool userNameCorrect = false; // is user name correct gets true if its in our username array
            int tries = 3; // the tries u have before u get logged out the system


            Console.WriteLine("hvad er dit brugernavn"); //getting the usernames 
            string getUserName = Console.ReadLine();
            Console.Clear();

            int indexOfUserNames = Array.IndexOf(userNames, getUserName); //gets the index of the username the user inserted we need it for our password login


            for (int i = 0; i < userNames.Length; i++) // checking if user name is correct
            {

                if (getUserName == userNames[i])
                {
                    Console.WriteLine("Hej {0} hvad er din adgangskode", getUserName);
                    userNameCorrect = true; // if user name is correct the bool gets true and u have unlocked to password 

                }

            }
            
                if (userNameCorrect == false ) // if its still false say wrong username 
                {
                    Console.WriteLine("forkert brugernavn");
                }

            while (tries > 0) // keep running if tries before u get locked out is over 0 
            {
                

                if (userNameCorrect == true) // our boolean from before 
                {
                    string getPassWord = Console.ReadLine();

                    int indexOfPassWords = Array.IndexOf(passWords, getPassWord); // gets the index of the password the user inserted to see if it match with username index


                    if (indexOfPassWords == indexOfUserNames) // check indexes
                    {
                       
                        Console.WriteLine("adgang godkendt velkommen til systemet {0}", getUserName); // and u got in 
                        
                    }

                   else if(indexOfPassWords != indexOfUserNames) // else if index is not the same lose a try
                    {
                        tries--;
                        Console.WriteLine("adgang nægtede du har antal forsøg tilbage: {0} inden du bliver låst ude", tries);
                    }

                    

                    if (tries == 0) // if tries are 0 then u get locked out
                    {
                        Console.WriteLine("Du er blevet låst ude af system {0} da du har har skrevet dit kodeord forkert mere end 3 gange", getUserName);
                    }
                }
            } 
                    
                
                {

                }
            }
        }

                
            
        }
    

