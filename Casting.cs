using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    //base /  parent class
    internal class Casting
    {
        public void M1()
        {
            Console.WriteLine("hello i am from parent class");
        }
    }

    internal class Casting2:Casting
    {
        public void M2()
        {
            Console.WriteLine("hello i am from child class");
        }
    }

}
