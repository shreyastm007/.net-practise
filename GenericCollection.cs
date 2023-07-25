using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    internal class GenericCollection
    {

        public void test()
        {
            //methods in the list are list.Add()
            //list.Contains(), list.Remove(), list.Reverse(), list.FindAll()
            //declairation of list

            List<string> evenNumbers = new List<string>();
            evenNumbers.Add("shanthala");
            evenNumbers.Add("Akshata");
            evenNumbers.Add("Avi");
            evenNumbers.Add("Nayana");
            evenNumbers.Add("Namana");
            evenNumbers.Add("Prajwal");

            //for(int i = 0; i < evenNumbers.Count; i++)
            //{
            //    Console.WriteLine(evenNumbers[i]);
            //}

            


            foreach(string names in evenNumbers)
            {
                Console.WriteLine(names);
            }


            //Dictinory 
            //Dictinory is collection of key and value type
            //Add(), Remove(),TryAdd(),ContainsKey(), ContainsValue() , Dictionary.keys
            Dictionary<string, int> evenNumbers3 = new Dictionary<string, int>();

            evenNumbers3.Add("one", 1);
            evenNumbers3.Add("two", 2);
            evenNumbers3.Add("three", 3);
            evenNumbers3.Add("four", 4);
            evenNumbers3.Add("five", 5);

            Console.WriteLine(evenNumbers3.ContainsValue(4));





        }
    }
}
