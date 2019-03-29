using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDiemnsionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int bb = 2;
            //    for (int il = 0; il < 3000; il++)
            //    {
            //        bb++;


            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Random matrixrng = new Random();
            //        int a = matrixrng.Next(1, 21471000);
            //        int b = matrixrng.Next(1, 21471000);
            //        int c = matrixrng.Next(1, 21471000);
            //        int d = matrixrng.Next(1, 21471000);
            //        int e = matrixrng.Next(1, 21471000);
            //        int f = matrixrng.Next(1, 21471000);
            //        int g = matrixrng.Next(1, 21471000);
            //        int h = matrixrng.Next(1, 21471000);
            //        int i = matrixrng.Next(1, 21471000);
            //        int j = matrixrng.Next(1, 21471000);
            //        int k = matrixrng.Next(1, 21471000);
            //        int l = matrixrng.Next(1, 21471000);
            //        int m = matrixrng.Next(1, 21471000);
            //        int n = matrixrng.Next(1, 21471000);
            //        int o = matrixrng.Next(1, 21471000);
            //        int p = matrixrng.Next(1, 21471000);
            //        int q = matrixrng.Next(1, 21471000);
            //        int x = matrixrng.Next(1, 21471000);
            //        int z = matrixrng.Next(1, 21471000);
            //        int t = matrixrng.Next(1, 21471000);


            //        int[] matrixarray = { a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, x, z, t };
            //        Console.WriteLine(string.Join(" ", matrixarray));



            //            string password = string.Join(" ", matrixarray);
            //            string fileName = "password.txt";
            //            File.Create(fileName).Close();
            //            FileInfo file = new FileInfo(fileName);

            //            using (StreamWriter sw = file.AppendText())
            //            {

            //                sw.Write("Ur New Password: " + password);
            //                Console.WriteLine("password Saved");
            //                Console.WriteLine("mighty ass password er:Math231412321");
            //            }



            //    }
            //makes up our random characters after the length of our password. 
            int length = 1000;
            var stringChars = new char[length];
            int legnth = 10000;
           
                    for (int i = 0; i < legnth; i++)
                    {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
                Console.ForegroundColor = ConsoleColor.Green;
                stringChars[i] = chars[random.Next(chars.Length)];
                        Console.WriteLine(stringChars);
                Console.WriteLine(stringChars);
                Console.WriteLine(stringChars);
                Console.WriteLine(stringChars);
                Console.WriteLine(stringChars);
                Console.WriteLine(stringChars);
                Console.WriteLine(stringChars);


            }

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
                        

        }
    }



    
    

