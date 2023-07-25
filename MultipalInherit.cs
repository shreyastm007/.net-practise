using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    public class MultipalInherit
    {
        //implimentation or body for a method is must
        public void Substract()
        {

        }
       
    }

    //interface
    interface IMultipalInherit
    {

        //implimentation is optional
        //interface must always have static fields
        //all the properties must be implimented
        public static string name;
        public int Add();

    }

    public class ClassA : IMultipalInherit
    {
        public string name = "shanthala";

        public int Add()
        {
            return 10 + 20;
        }
    }
}
