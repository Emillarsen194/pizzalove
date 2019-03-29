using System;

class EntryPoint
{
    static void Main()
    {
        int nummer = 5;


        Console.WriteLine(nummer);

        string helloWorld = "Hej verden";
        Console.WriteLine(helloWorld);

        char bogstav = 'a';

        Console.WriteLine(bogstav);

        bool areEqual = true;

        Console.WriteLine(areEqual);

        float mathPI = 3.14F;

        Console.WriteLine(mathPI);

        var gange = nummer * mathPI;

        Console.WriteLine(gange);

        Console.WriteLine("---------------------");
        Console.WriteLine("int max og min value");
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);
        Console.WriteLine();
        uint minusUNummre = 1; //unsigned int 
        Console.WriteLine(uint.MaxValue);
        Console.WriteLine(uint.MinValue);
        Console.WriteLine();

        byte lavenumre = 200; //byte inholder 8 bit så den går fra 0 - 255

        sbyte negativbyte = -1; //signed byte -128 to 127

        Console.WriteLine(sbyte.MaxValue);
        Console.WriteLine(sbyte.MinValue);

        //long type holds 64bit numbers

        long someVeryLongNumber = 345552342342;
        Console.WriteLine();
        Console.WriteLine(long.MinValue);
        Console.WriteLine(long.MaxValue);

        //unsigned long

        ulong noNegativeLongNumbers = 0;
        Console.WriteLine(ulong.MaxValue);

        Console.WriteLine("------------------------");
        Console.WriteLine("strings");


        string firstString = "emil ";
        string secondString = "larsen";
        string mellemRum = " ";


        //concatenation


        Console.WriteLine("Mit navn er" + firstString + " " + secondString + " og jeg er virkelig glad");
        Console.WriteLine("mit navn er {0}{1}{2} og jeg er virkelig glad", firstString, mellemRum, secondString);


        //arrays

        string iAmArray = "array";

        Console.WriteLine(iAmArray);
        Console.WriteLine(iAmArray[4]);
        Console.WriteLine();

        string[] iAmStringArray = { "hej", "med", "dig", "dwdad" };


        Console.WriteLine(iAmStringArray.Length);

        int[] Integeararray = new int[5];

        Integeararray[3] = 123;
    }
}