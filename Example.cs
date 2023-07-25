using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    public class Example
    {
        public virtual void Method1()
        {
            Console.WriteLine("hey i am from parent class");
        }

        public void Method1(int a)
        {
            Console.WriteLine("hey i am methos with parameter {0}", a);
        }

    }

    public class Example1 : Example
    { 
         public override void Method1()
        {
            Console.WriteLine("i am from the derived class");
        }
    }


}
