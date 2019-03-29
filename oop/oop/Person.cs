using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Person
    {
        public String name;
        private int age;


        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
       public Person()
        {

        }

        public Person(String n, int a)
        {
            this.name = n;
            this.age = a;


        }


        public void Eat()
        {
            Console.WriteLine("eat...mums");
        }

        public String Sleep(int time)
        {
            return "ZZZzzzZZZ";
        }

    }
}
