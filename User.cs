using System;
using System.Collections.Generic;
using System.Text;

//whatsapp example
namespace ConsoleAppForPractice
{
    public class User
    {
        public void chat()
        {
            Console.WriteLine("i can chat");
        }
        public void vc()
        {
            Console.WriteLine("i can vc");
        }
        public void postImage()
        {
            Console.WriteLine("i can post images");
        }

        public void sendDocs()
        {
            Console.WriteLine("i can send docs");
        }
        public void changeGrpName()
        {
            Console.WriteLine("i can change group name");
        }
    }

    //admin is a child class inherited
    //from use class(base class/parent class)
    public class Admin : User
    {
        // creating reference verible of user inside the admin class
        public void ristrict()
        {
            Console.WriteLine("i can ristrict user");
        }

        public void addUser()
        {
            Console.WriteLine("i can add users");
        }

    }

    public class SuperAdmin : Admin
    {
        public void authorAdmin()
        {
            Console.WriteLine("i can add or remove admins");

        }

    }

    //c# supports only single class inheritance

    public class a
    {

    }

    //public class b: User,a

    //base class are automatically instances whice the creation of child class

    //hirerchial inheritance




}
