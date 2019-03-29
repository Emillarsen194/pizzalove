using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace passgene
{
    class Program
    {


        static void Main(string[] args)
        {



            // wanna get the length of the password.
            Console.WriteLine("How many letters should the password be example write 10.");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("u choose {0} for u length of ur password press enter to get ur password and enter again if u want new one", length);


            while (true)
            {
                //makes up our random characters after the length of our password. 
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[length];
                var random = new Random();

                // if enter is pressed start making the password 
                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        for (int i = 0; i < stringChars.Length; i++)
                        {

                            stringChars[i] = chars[random.Next(chars.Length)];


                        }

                        //prints ur password 
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Ur password: ");
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine(new string('-', stringChars.Length));
                        Console.WriteLine(stringChars);
                        Console.WriteLine(new string('-', stringChars.Length));
                        Console.WriteLine("Save password to password.txt? click s and x to close application");


                        //safe the file and create if it does not exist '
                        if (Console.ReadKey(true).Key == ConsoleKey.S)
                        {

                            Console.ResetColor();
                            string password = new string(stringChars);
                            string fileName = "password.txt";
                            File.Create(fileName).Close();
                            FileInfo file = new FileInfo(fileName);

                            using (StreamWriter sw = file.AppendText())
                            {

                                sw.Write("Ur New Password: " + password);
                                Console.WriteLine("password Saved");



                            }
                        }

                        // used to close the application

                        if (Console.ReadKey(true).Key == ConsoleKey.X)
                        {
                            int j = 4;
                            for (int i = 0; i < 3; i++)
                            {
                                j--;
                                Console.WriteLine("closing in {0} seconds", j);
                                Thread.Sleep(1000);
                            }

                            Environment.Exit(0);
                        }

                    }
            }


        }
    }
}
    
               


