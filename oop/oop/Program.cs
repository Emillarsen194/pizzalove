using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Person perObj = new Person();

            perObj.name = "per";
            perObj.Age = 12;
            Console.WriteLine(perObj.Age);

            Person p1 = new Person("Bo", 5);

            
            String res = perObj.Sleep(12);

            Console.WriteLine(res);
        }
    }
}
