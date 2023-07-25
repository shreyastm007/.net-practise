using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{

    //ristricting  or encapsulating the accress of data and data members
    //by the accessspecifiers and properties
    internal class Student
    {

       
        private int id;
        private string name;
        public int _age
        {
            get
            {
                return (age == 0) ? 40 : _age;
            }
            set { _age = value; }
        }
        private int age;

        public void getId()
        {
            id = 10;
        }
        //write only
        public int setAge(int age)
        {
            if (age < 0 || age > 100)
            {
                throw new ArgumentException("age must not be less than 0 or greater than 100");
            }
            else
            {
                this.age = age;
                return this.age==0 ? age : _age;
            }


            //int a = (age < 0 || age > 100) ? throw new ArgumentException("age must not be less than 0 or greater than 100") : this.age = age;

            //return a;
        }

        //red the data

        public string getage()
        {
            string p = (age < 18) ? "person is minor" : "person is not minor";

            return p;

        }
    }
}
