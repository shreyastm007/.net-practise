using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    //keyword to declair a delegate is "delegate"
    //delegate should be declaired outside the class
    //deligate's signature must match  method signature
    
    delegate string message1Deligate(string message);
        public class DelegaeExample
    {
        public string message1(string message)
        {
            string a = message;
            Console.WriteLine("hey this is from message1 {0}", a);
            return a;
        }

        public string message2(string message)
        {
            string a = message;
            Console.WriteLine("hey this is from message2 {0}", a);
            return a;
        }

    }


}
