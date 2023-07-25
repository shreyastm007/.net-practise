using System;
using System.Collections.Generic;
using experimental;

namespace ConsoleAppForPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //LoopingExampe example = new LoopingExampe();

            //example.smartInsert(); //if else loop

            // example.insert(); //if loop

            // example.difference();   

            //example.question();

            //ParseTryParse test = new ParseTryParse();

            //test.testing();



            //SwitchExample example1 = new SwitchExample();
            //example1.testing();
            //example1.test1();

            //Car obj = new Car();
            //obj.color = "red";
            //obj.ride();


            //ExampleClasses.name = "hello";
            //ExampleClasses.method1();

            //ParrtialClass parrtialClass = new ParrtialClass();

            //parrtialClass.Addition(2,3);

            //parrtialClass.Substraction(6,3);

            //Access access = new Access();
            //access.id = -3;
            //access.setage(20);
            //access.name = "avi";

            //access.method1();

            //Console.WriteLine(access.getid());
            //Console.WriteLine(access.getage());

            //Admin _admin = new Admin();
            //_admin.sendDocs();
            //_admin.ristrict();

            //SuperAdmin _admin = new SuperAdmin();
            //_admin.addUser();
            //_admin.chat();
            //_admin.authorAdmin();

            //fit the lower type in the higher type

            //Example _example = new Example1();

            //Example1 _example2 = new Example1();

            //Example _example3 = new Example();


            //_example.Method1(9);
            //_example2.Method1(5);
            //_example3.Method1(10);

            //_example.Method1();  //parent class method
            //_example2.Method1(); //child class
            //_example3.Method1(); //parent class


            //runtime polymorphism (time where the memory allocation is done)
            //compail time polymorphism (something before runtime)

            //a method acing different when it is called through
            //different object reference

            //Runtime polymorphism
            //Drawing _drawing = new Drawing();
            //Console.WriteLine(_drawing.Area(10));// 0

            //Drawing _drawing2 = new Circle();
            //Console.WriteLine(_drawing2.Area(10));// 314

            //Circle _drawing3 = new Square();
            //Console.WriteLine(_drawing3.Area(10));//100

            //instance creation
            //initlazing the value


            //Constructor ref1 = new Constructor(10);
            //Constructor ref2 =new Constructor("Akshata",2);
            //Constructor constructor1 = new Constructor(); //user defined constructor with no parameter

            //Console.WriteLine(ref1.id);
            //Console.WriteLine(ref2.name , ref2.id);


            //Constructor2 ref3 = new Constructor2("namana", 30);
            //Constructor2 ref4 = new Constructor2(10);
            //Console.WriteLine(ref3.y);
            //Console.WriteLine(ref3.x);


            //Constructor2 ref5 = new Constructor2("avi",2,"namana");
            //Console.WriteLine(ref5.y); //avi
            //Console.WriteLine(ref5.x);//2
            //Console.WriteLine(ref5.name);//namana

            //Student student = new Student();
            //student.setAge(30); 
            //student.setAge(-20);
            //Console.WriteLine(student.getage());

            //upcasting
            //Casting  casting = new Casting2();

            //down casting
            //Casting2 casting2 = new Casting(); //child class is bigger than parent class since it contain all the properties parent and methods of parent  class as well as  child class

            //Encapsulation

            //Encapsulation E = new Encapsulation();

            //E.setAge(20);
            //E.id = 2;

            //E.getAge();

            //array
            //Types t = new Types();
            //t.initilize();

            //MultiDimention array

            // MultiDimention Ma = new MultiDimention();

            //Ma.InitTwoDimention();
            //Ma.ThreeDimention();    
            //Ma.JaggedArray();

            //Exception handeling

           // Exceptions exceptions = new Exceptions();

            //exceptions.ThrowException();

            //system.io exception


            //exceptions.ioException();

            //generic class

            //GenericType<string> genericTypeString = new GenericType<string>();
            //Console.WriteLine(genericTypeString.names = "Akshantha");

            //GenericType<int> genericTypeint = new GenericType<int>();
            //Console.WriteLine(genericTypeint.age = 22);
            //generic method
            // genericTypeint.test2<string>("avi", 20);


            //generic collections

            //list
            //GenericCollection genericCollection = new GenericCollection();
            // genericCollection.test();


            //Attribute 

            //Calculatur calculatur = new Calculatur();
            //calculatur.Add(20, 30);


            //single cast delegates
            //multi cast delegates
            //DelegaeExample delegaeExample = new DelegaeExample();
           // message1Deligate del = new message1Deligate(delegaeExample.message2);
            //del("hello i am from delegate");


           // Service service = new Service();
            //Service1 service1 = new Service1();
            //serviceDeligate del2 = new serviceDeligate(service.messageService);
            //serviceDeligate del3 = new serviceDeligate(service1.EmailService);


            //del2("this is message service method");
            //del2("this is message service method");



            //calling methods without delegate
            DelegaeExample delegaeExample = new DelegaeExample();

            delegaeExample.message1("hey i am from obj ref call");
            delegaeExample.message2("hey i am from obj ref call");















        }




    }
}
