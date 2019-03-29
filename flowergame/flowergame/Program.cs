using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace flowergame
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                
                Console.Title = "Flower Game";
                

                Random r = new Random();
           

                while (true)
                {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("             MADE BY EMIL LARSEN AT ZBC RINGSTED");
                Console.WriteLine("             Copyright @2018 all rights RESERVRED");
                Console.WriteLine("---------------------------------------------------------------------");
                Thread.Sleep(1000);
                Console.Clear();
                int sum = 500; // change starter money
                string valuta = "M"; // change currency if u want dkk or M or gold or somthing else.

              

                while (sum > 0)
                {
                    int rng = r.Next(1, 8);



                    Console.WriteLine("How much to bet for you got " + sum + valuta);
                    int pengeinput = int.Parse(Console.ReadLine());
                    Console.WriteLine("|1 = purple | 2 = blue | 3 = pastel | 4 = red | = 5 yellow | 6 = orange | 7 = rainbow | 8 = hot | 9  = cold|");
                    int userinput = int.Parse(Console.ReadLine());

                    Console.ResetColor();

                    if (pengeinput <= sum)
                    {
                       



                  

                        if (userinput == rng)
                        {
                            switch (userinput)
                            {
                                case 1:
                                    pengeinput = pengeinput * 6;
                                    sum += pengeinput;



                                    Blomst(rng);

                                    Flower("Purple Flower", pengeinput, sum, valuta);

                                    break;
                                case 2:

                                    pengeinput = pengeinput * 6;

                                    Blomst(rng);
                                    sum += pengeinput;
                                    Flower("Blue Flower", pengeinput, sum, valuta);

                                    break;
                                case 3:
                                    pengeinput = pengeinput * 6;
                                    sum += pengeinput;

                                    Blomst(rng);
                                    Flower("Pastel Flower", pengeinput, sum, valuta);

                                    break;
                                case 4:
                                    pengeinput = pengeinput * 6;
                                    sum += pengeinput;

                                    Blomst(rng);
                                    Flower("Red Flower", pengeinput, sum, valuta);

                                    break;
                                case 5:
                                    pengeinput = pengeinput * 6;
                                    sum += pengeinput;

                                    Blomst(rng);
                                    Flower("Yellow Flower", pengeinput, sum, valuta);

                                    break;
                                case 6:
                                    pengeinput = pengeinput * 6;
                                    sum += pengeinput;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Blomst(rng);
                                    Flower("Orange", pengeinput, sum, valuta);

                                    break;
                                case 7:
                                    pengeinput = pengeinput * 6;
                                    sum += pengeinput;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Blomst(rng);
                                    Flower("Rainbow Flower", pengeinput, sum, valuta);
                                    break; 





                            }





                        }
                        else if (userinput < 8 && rng != userinput) // lose cold
                        {
                            switch (rng)
                            {
                                case 1:

                                    sum -= pengeinput;



                                    Blomst(rng);

                                    lose("Purple Flower", pengeinput, sum, valuta);

                                    break;
                                case 2:


                                    Blomst(rng);
                                    sum -= pengeinput;
                                    lose("Blue Flower", pengeinput, sum, valuta);

                                    break;
                                case 3:

                                    sum -= pengeinput;

                                    Blomst(rng);
                                    lose("Pastel Flower", pengeinput, sum, valuta);

                                    break;
                                case 4:

                                    sum -= pengeinput;

                                    Blomst(rng);
                                    lose("Red Flower", pengeinput, sum, valuta);

                                    break;
                                case 5:

                                    sum -= pengeinput;

                                    Blomst(rng);
                                    lose("Yellow Flower", pengeinput, sum, valuta);
                                    break;


                                case 6:
                                    sum -= pengeinput;

                                    Blomst(rng);
                                    lose("Orange", pengeinput, sum, valuta);

                                    break;
                                case 7:

                                    sum -= pengeinput;

                                    Blomst(rng);
                                    lose("Rainbow Flower", pengeinput, sum, valuta);
                                    break;


                            }
                        }
                        else if (userinput == 9)
                        {
                            switch (rng)
                            {


                                case 1:
                                    sum = pengeinput + sum;
                                    pengeinput = pengeinput + pengeinput;
                                    Blomst(rng);
                                    wincold("purple", pengeinput, sum, valuta);
                                    break;
                                case 2:
                                    sum = pengeinput + sum;
                                    pengeinput = pengeinput + pengeinput;
                                    Blomst(rng);
                                    wincold("Blue", pengeinput, sum, valuta);
                                    break;
                                case 3:
                                    sum = pengeinput + sum;
                                    pengeinput = pengeinput + pengeinput;
                                    Blomst(rng);
                                    wincold("blue", pengeinput, sum, valuta);
                                    break;
                                    
                                case 4:
                                    sum -= pengeinput;
                                    Blomst(rng);
                                    losecold("red", pengeinput, sum, valuta);
                                    break;
                                case 5:
                                    sum -= pengeinput;
                                    Blomst(rng);
                                    losecold("yellow", pengeinput, sum, valuta);
                                    break;
                                case 6:
                                    sum -= pengeinput;
                                    Blomst(rng);
                                    losecold("Orange", pengeinput, sum, valuta);
                                    break;
                                case 7:
                                    sum -= pengeinput;
                                    Blomst(rng);
                                    losecold("Rainbow", pengeinput, sum, valuta);
                                    break;



                            }
                        }

                        else if (userinput == 8)
                        {
                            switch (rng)
                            {
                                case 1:
                                    sum = sum - pengeinput;
                                    Blomst(rng);
                                    losehot("Purple", pengeinput, sum, valuta);
                                    break;
                                case 2:
                                    sum = sum - pengeinput;
                                    Blomst(rng);
                                    losehot("Blue", pengeinput, sum, valuta);
                                    break;
                                case 3:
                                    sum = sum - pengeinput;
                                    Blomst(rng);
                                    losehot("Pastle", pengeinput, sum, valuta);
                                    break;
                                case 4:
                                    sum = pengeinput + sum;
                                    pengeinput = pengeinput + pengeinput;
                                    Blomst(rng);
                                    winhot("Red", pengeinput, sum, valuta);
                                    break;
                                case 5:
                                    sum = pengeinput + sum;
                                    pengeinput = pengeinput + pengeinput;
                                    Blomst(rng);
                                    winhot("Yellow", pengeinput, sum, valuta);
                                    break;
                                case 6:
                                    sum = pengeinput + sum;
                                    pengeinput = pengeinput + pengeinput;
                                    Blomst(rng);
                                    winhot("Orange", pengeinput, sum, valuta);
                                    break;
                                case 7:
                                    sum = sum - pengeinput;
                                    Blomst(rng);
                                    losehot("Rainbow", pengeinput, sum, valuta);
                                    break;
                            }

                        }





                    }
                }
                if (sum < 2)
                {
                    Console.WriteLine("Game Starting over u lost all ur money please wait 2 second");
                    Thread.Sleep(2000);
                    Console.Clear();
                }


            }
        }

        public static void Flower(string color, int pengeinput, int sum, string valuta)
        {

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("You got a " + color + " and won: " + pengeinput + valuta);
            Console.WriteLine("You now got " + sum + "{0} to play for", valuta);
            Console.WriteLine("----------------------------------------------------------------");

        }

        public static void lose(string color, int pengeinput, int sum, string valuta)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("You got a " + color + " lost " + pengeinput + valuta);
            Console.WriteLine("You now got " + sum + "{0} to play for", valuta);
            Console.WriteLine("----------------------------------------------------------------");
        }   

        public static void wincold(string color, int pengeinput, int sum, string valuta)
        {
            
            
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("You got a " + color + " won " + pengeinput + valuta);
            Console.WriteLine("You now got " + sum + "{0} to play for", valuta);
            Console.WriteLine("----------------------------------------------------------------");
        }

        public static void losecold(string color, int pengeinput, int sum, string valuta)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("You got a " + color + " lost " + pengeinput + valuta);
            Console.WriteLine("You now got " + sum + "{0} to play for", valuta);
            Console.WriteLine("----------------------------------------------------------------");
        }

        public static void losehot(string color, int pengeinput, int sum, string valuta)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("You got a " + color + " lost " + pengeinput + valuta);
            Console.WriteLine("You now got " + sum + "{0} to play for", valuta);
            Console.WriteLine("----------------------------------------------------------------");
        }

        public static void winhot(string color, int pengeinput, int sum, string valuta)
        {
           
            
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("You got a " + color + " won " + pengeinput + valuta);
            Console.WriteLine("You now got " + sum + "{0} to play for", valuta);
            Console.WriteLine("----------------------------------------------------------------");
        }


        public static void Blomst(int rng)
        {
            switch (rng)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;




            }
          


            Console.WriteLine("                           vVVVv");
            Console.WriteLine("                           (___)");
            Console.WriteLine("                            ~Y~");
            Console.WriteLine(@"                            \|/");
            Console.WriteLine(@"                           \\|//");
            Console.WriteLine("                           ^^^^^");



        }
        
    }
}
                                  
                          




