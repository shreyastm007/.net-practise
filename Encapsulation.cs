using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    internal class Encapsulation
    {
        private int id;
        private string name;
        private int age;

        public int setAge(int a)
        {
            if(a < 0 || a > 100)
            {
                throw new Exception("the age must be greater than 0 and less than 100");
            }
            else
            {
                this.age = a;
                return age;
            }
            
        }

        public int getAge()
        {
            Console.WriteLine("age is {0}", age);
            return age;   
        }
        //public void Display()
        //{
        //    Console.WriteLine("age is: {0}, name: {1}, id is {2}", age, name, id);
        //} 
    }
}
