using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello wORLD");
            byte number = 5;
            int count = 10;
            float TotalPrice = 20.95f;
            char character = 'A';
            string firstName = "Emil";
            bool isWorking = false;
            Console.WriteLine(number);
            int tal = 5;
            var talet = 1000-100;
            var plus = tal + talet;
            Console.WriteLine(plus);
            Console.WriteLine("hej med dig");
            Console.WriteLine(count);
            Console.WriteLine(TotalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            
        }

    }
}
