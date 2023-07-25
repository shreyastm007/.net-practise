using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    delegate void serviceDeligate(string message)
    //delegate is agreement/contract between publisher and a subscriber
    internal class Service
    {
        public string cradit { get; set; }
        public string debit { get; set; }

        //message servics 
        public void messageService(string a)
        {
            Console.WriteLine("amount has cradited/debited to the user {0}", a);
        }
        
    }


    internal class Service1
    {
        public string cradit { get; set; }
        public string debit { get; set; }

        //gmails service 
        public void EmailService(string b)
        {
            Console.WriteLine("amount has cradited/debited to the user {0}", b);
        }
    }
}
