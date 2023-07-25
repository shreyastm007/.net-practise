using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    //constructor is similor to a method but it has no return type
    //a constructor has the same name as class name
    public class Constructor
    {
        public int id;
        public string name;

        //used defined constructor then the default constructor will not be there
        //constructor overloading
        public Constructor(string a)
        {
            name = a;
            Console.WriteLine("From base class with string parameter");
        }

        public Constructor(string b, int a) 
        {
            this.name = b;
        }

        //public Constructor(int a, string b)
        //{
        //    id= a;  name = b;
        //}

        //user defined constructor with no parameters (to achive default constructor)

        public Constructor()
        {
            
        }
    }


    public class Constructor2 : Constructor
    {
        
        public int x;
        public string y;

        public Constructor2(int c)
        {
            x = c;
        }

        public Constructor2(string a)
        {
            y = a;
        }

        public Constructor2(string a, int b) : this(b)
        {
            y = a;
        }

        //why is the base constructor create before creation of child class constructor,
        //even though the clild class constructor is called first.
        public Constructor2(string a, int b, string x):base(x)
        {
            this.y = a;
            this.x = b;
            Console.WriteLine("From con2 with 3 parameters");
        }
        

    }
}
