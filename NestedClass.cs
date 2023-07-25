using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    //Class inside a class is calles nested class
    //main use the private mebers inside the nested class.
    public class NestedClass
    {
        public string name;

        private void method()
        {
            Console.WriteLine("hello i am a pribvate method");
        }


        public class NestedClass1
        {

        }
    }

    public class NestedClass1
    {
       
        public void method1()
        {
        NestedClass obj = new NestedClass();
            obj.name = "hello";
        }

    }
}
