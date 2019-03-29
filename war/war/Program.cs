using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace war
{
    class Program
    {


        static void Main(string[] args)
        {



            while (true)
            {
                int bank = 100;

                while (bank > 0)
                {



                    Random r = new Random();



                    int rng = r.Next(1, 13);
                    int brng = r.Next(1, 13);


                    Console.WriteLine("How much do u wanna bet u got {0}", bank);
                    int bet = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("ready for war? y/n");
                    string yn = Console.ReadLine();

                    if (bet <= bank)
                    {

                        if (yn == "y")
                        {
                            Console.Clear();
                            switch (rng)
                            {

                                case 1:
                                    Console.WriteLine("you got ace");
                                    break;
                                case 2:
                                    Console.WriteLine("you got 2");
                                    break;
                                case 3:
                                    Console.WriteLine("you got 3");
                                    break;
                                case 4:
                                    Console.WriteLine("you got 4");
                                    break;
                                case 5:
                                    Console.WriteLine("you got 5");
                                    break;
                                case 6:
                                    Console.WriteLine("you got 6");
                                    break;
                                case 7:
                                    Console.WriteLine("you got 7");
                                    break;
                                case 8:
                                    Console.WriteLine("you got 8");
                                    break;
                                case 9:
                                    Console.WriteLine("you got 9");
                                    break;
                                case 10:
                                    Console.WriteLine("you got 10");
                                    break;
                                case 11:
                                    Console.WriteLine("you got jack");
                                    break;
                                case 12:
                                    Console.WriteLine("you got queen");
                                    break;
                                case 13:
                                    Console.WriteLine("you got king");
                                    break;



                            }

                            switch (brng)
                            {

                                case 1:
                                    Console.WriteLine("bank got ace");
                                    break;
                                case 2:
                                    Console.WriteLine("bank got 2");
                                    break;
                                case 3:
                                    Console.WriteLine("bank got 3");
                                    break;
                                case 4:
                                    Console.WriteLine("bank got 4");
                                    break;
                                case 5:
                                    Console.WriteLine("bank got 5");
                                    break;
                                case 6:
                                    Console.WriteLine("bank got 6");
                                    break;
                                case 7:
                                    Console.WriteLine("bank got 7");
                                    break;
                                case 8:
                                    Console.WriteLine("bank got 8");
                                    break;
                                case 9:
                                    Console.WriteLine("bank got 9");
                                    break;
                                case 10:
                                    Console.WriteLine("bank got 10");
                                    break;
                                case 11:
                                    Console.WriteLine("bank got jack");
                                    break;
                                case 12:
                                    Console.WriteLine("bank got queen");
                                    break;
                                case 13:
                                    Console.WriteLine("bank got king");
                                    break;



                            }

                            if (brng > rng)
                            {
                                bank -= bet;
                                Console.WriteLine("ur number was lower than the banks u lost {0}", bet);
                            }

                            else if (brng < rng)
                            {
                                bank += bet;
                                Console.WriteLine("Ur card was higher than {0} u won {1}", brng, bet);
                            }

                            else if (brng == rng)
                            {

                                Console.WriteLine("ur card {0} was equal to banks card {1} do u wish to continue war and double ur bet yes or no", rng, brng);
                                string ja = Console.ReadLine();


                                if (ja == "y")
                                {





                                }

                            }
                        }



                    }








                }

            }
        }
        public static void Randome(int rng)
        {
            rng = 20;
            switch (rng)
            {

                case 1:
                    Console.WriteLine("you got ace");
                    break;
                case 2:
                    Console.WriteLine("you got 2");
                    break;
                case 3:
                    Console.WriteLine("you got 3");
                    break;
                case 4:
                    Console.WriteLine("you got 4");
                    break;
                case 5:
                    Console.WriteLine("you got 5");
                    break;
                case 6:
                    Console.WriteLine("you got 6");
                    break;
                case 7:
                    Console.WriteLine("you got 7");
                    break;
                case 8:
                    Console.WriteLine("you got 8");
                    break;
                case 9:
                    Console.WriteLine("you got 9");
                    break;
                case 10:
                    Console.WriteLine("you got 10");
                    break;
                case 11:
                    Console.WriteLine("you got jack");
                    break;
                case 12:
                    Console.WriteLine("you got queen");
                    break;
                case 13:
                    Console.WriteLine("you got king");
                    break;
            }
        }

        public static void Randomes(int brng)
        {
            brng = 20;
            switch (brng)
            {

                case 1:
                    Console.WriteLine("bank got ace");
                    break;
                case 2:
                    Console.WriteLine("bank got 2");
                    break;
                case 3:
                    Console.WriteLine("bank got 3");
                    break;
                case 4:
                    Console.WriteLine("bank got 4");
                    break;
                case 5:
                    Console.WriteLine("bank got 5");
                    break;
                case 6:
                    Console.WriteLine("bank got 6");
                    break;
                case 7:
                    Console.WriteLine("bank got 7");
                    break;
                case 8:
                    Console.WriteLine("bank got 8");
                    break;
                case 9:
                    Console.WriteLine("bank got 9");
                    break;
                case 10:
                    Console.WriteLine("bank got 10");
                    break;
                case 11:
                    Console.WriteLine("bank got jack");
                    break;
                case 12:
                    Console.WriteLine("bank got queen");
                    break;
                case 13:
                    Console.WriteLine("bank got king");
                    break;

            }

        }

    }







}