using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    //generic is a class, it will allow us to define classes and methods with the placeholder.
    internal class GenericType<t>
    {
        public t names;
        public t age;

        public void testing()
        {
            Console.WriteLine("name and  age is {0} {1}", names , age);
        }


        public void test2<type>(type a, t value)
        {
            Console.Write("{0},{1}", a , value);
        }
        

    }
}
