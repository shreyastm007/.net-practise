using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    //normal instance class
    //cant create an abstract method inside a instance class
    public class PlainClass
    {
        public void m1()
        {


        }

    }


    //interface of a normal instance class
    //we can store the abstract method inside the interface
    //we cant create instance for interface, always we need an implimentation
    //class to access the members of interface
    //
    public interface IPlainClass
    {
        public static int a;
        void m2();
       

    }


    //abstract class
    //in the abstract class creating an abstract method is possible
    //we cant create interface or an instanvce of an abstract class
    // hiding the complex functionalaty and providing only implimentatin
    public abstract class Bank
    {
        public abstract void interest();

        public void transaction()
        {

        }
        public void LockerFunction()
        {

        }
        public void CashFlow()
        {

        }

        public void Employees()
        {

        }
    }

    public interface IBank
    {
        public void debit();
        public void credit();
    }

    //why no overide kryword through interface.
    //go through the difference between interface and an abstract class
    public class ICICI : Bank , IBank
    {
        public override void interest()
        {
            Console.WriteLine("2% interest in ICICI bank");
        }

        public void debit() { }
        public void credit() { }

    }

    public class BOB : Bank
    {
        public override void interest()
        {
            Console.WriteLine("3% interest in ICICI bank");
        }

    }
}
