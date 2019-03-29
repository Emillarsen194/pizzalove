using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Er det et brev eller en pakke du vil sende");
            string letterOrPackage = Console.ReadLine().ToLower(); // getting information if it is a package or letter that u will send to lower makes it lowercase

            Console.WriteLine("Hvilke af de 2 lande skal det sendes til du kan vælge mellem Danmark og England"); 
            string country = Console.ReadLine().ToLower(); // getting information on which country u will send the package to lower makes it lower case for fault tolerence

            Console.WriteLine(country);


            if (letterOrPackage == "brev") // if its a letter lets get the information about the letter
            {

                Console.WriteLine("Brevets længde i cm");
                double l = double.Parse(Console.ReadLine()); // letters length
                Console.WriteLine("brevets højde i cm");
                double h = double.Parse(Console.ReadLine()); // height on letter
                Console.WriteLine("brevets bredde i cm");
                double b = double.Parse(Console.ReadLine()); // letters width

                double lengthHightWidth = l + h + b; // taking our length height and width and pluses them together
                Console.WriteLine("brevets vægt i gram");
                double g = double.Parse(Console.ReadLine()); // getting our weight on the letter
                double v = Math.Floor(g); // rounding the weight so that we dont get any commas



                if (country == "danmark") //if country is danmark in lowercase thats why we are using .tolower() 
                {
                    

                    if (lengthHightWidth < 90 && v <= 50) // if l+b+h is lower than 90 and weight is lower or the same as 50 we got the cheap letter
                    {
                        Console.WriteLine("det vil koste 10kr at sende dit brev");
                    }

                    else if (lengthHightWidth <= 90 && v <= 100)
                    {
                        Console.WriteLine("det vil koste 20kr at sende dit brev");
                    }

                    else if (lengthHightWidth <= 90 && v <= 500)
                    {
                        Console.WriteLine("det vil koste 60kr at sende dit brev");
                    }

                    else if (lengthHightWidth <= 90 && v <= 1000)
                    {
                        Console.WriteLine("det vil koste kr at 75kr at sende dit brev");
                    }
                    else if (lengthHightWidth > 91) // if letter is bigger than 91cm2 tell the user it can be over 90
                    {
                        Console.WriteLine("Dit brev må max være 90 cm samlagt med L+H+B");
                    }

                    else if (v >= 1001) // if the weight is over 1000gram tell the user the letter cant be over 1000g
                    {
                        Console.WriteLine("vægten på dit brev må max være 1000g");
                    }

                }

                if (country == "england") // if country is england run this code instead still get the information about the letter
                {


                    if (lengthHightWidth < 90 && v <= 50)
                    {
                        Console.WriteLine("det vil koste 30kr at sende dit brev");
                    }

                    else if (lengthHightWidth <= 90 && v <= 100)
                    {
                        Console.WriteLine("det vil koste 35kr at sende dit brev");
                    }

                    else if (lengthHightWidth <= 90 && v <= 500)
                    {
                        Console.WriteLine("det vil koste 90kr at sende dit brev");
                    }

                    else if (lengthHightWidth <= 90 && v <= 1000)
                    {
                        Console.WriteLine("det vil koste kr at 100kr at sende dit brev");
                    }
                    else if (lengthHightWidth > 91)
                    {
                        Console.WriteLine("Dit brev må max være 90 cm samlagt med L+H+B");
                    }

                    else if (v >= 1001)
                    {
                        Console.WriteLine("vægten på dit brev må max være 1000g");
                    }
                }

            }

            if (letterOrPackage == "pakke" || letterOrPackage == "Pakke") // this is our package area
            {
                Console.WriteLine("Pakkens længde i cm");
                double l = double.Parse(Console.ReadLine()); 
                Console.WriteLine("Pakkens højde i cm");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine("Pakkens bredde i cm");
                double b = double.Parse(Console.ReadLine());

                double lengthHightWidth = l + h + b;
                Console.WriteLine("Pakkens vægt i gram");
                double g = double.Parse(Console.ReadLine());
                int v = int.Parse(Math.Floor(g).ToString());

              

                if (country == "danmark") // if the country is denmark
                {
                    

                    if (lengthHightWidth < 150 && v <= 1000)
                    {
                        Console.WriteLine("det vil koste 60kr at sende din pakke");
                    }

                    else if (lengthHightWidth <= 250 && v <= 2000)
                    {
                        Console.WriteLine("det vil koste 100kr at sende din pakke");
                    }

                    else if (lengthHightWidth <= 300 && v <= 4000)
                    {
                        Console.WriteLine("det vil koste 175kr at sende din pakke");
                    }

                    else if (lengthHightWidth <= 375 && v <= 5000)
                    {
                        Console.WriteLine("det vil koste kr at 200kr at sende din pakke");
                    }
                    else if (lengthHightWidth > 376)
                    {
                        Console.WriteLine("Din pakke må max være 375 cm samlagt med L+H+B");
                    }

                    else if (v >= 5001)
                    {
                        Console.WriteLine("vægten på din pakke må max være 5000g");
                    }

                }

                if (country == "england") // if u wanna send the package to england
                {


                    if (lengthHightWidth < 150 && v <= 1000)
                    {
                        Console.WriteLine("det vil koste 200kr at sende din pakke");
                    }

                    else if (lengthHightWidth <= 250 && v <= 2000)
                    {
                        Console.WriteLine("det vil koste 300kr at sende din pakke");
                    }

                    else if (lengthHightWidth <= 300 && v <= 4000)
                    {
                        Console.WriteLine("det vil koste 425kr at sende din pakke");
                    }

                    else if (lengthHightWidth <= 375 && v <= 5000)
                    {
                        Console.WriteLine("det vil koste kr at 500kr at sende din pakke");
                    }
                    else if (lengthHightWidth > 376)
                    {
                        Console.WriteLine("Din pakke må max være 90 cm samlagt med L+H+B");
                    }

                    else if (v >= 5001)
                    {
                        Console.WriteLine("vægten på din pakke må max være 5000g");
                    }
                }



            }

        }









        }

    }

