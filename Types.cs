using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    internal class Types
    {
        //it is fixed in size we need to specify the length of an array
        //index is always 0  end index will always be n-1
        public  int[]  evenNumbers = new int[4]; //declairing an arrinay

        //initilization of array elements

        public void initilize()
        {
            evenNumbers[0] = 2;
            evenNumbers[1] = 4;
            evenNumbers[2] = 6;
            evenNumbers[3] = 8;
            evenNumbers[4] = 10; //index out of bound exception

            Console.WriteLine("1st even {0}", evenNumbers[0]);
           // Console.WriteLine("last even",evenNumbers[4]);

            //initilize and declair an arry in a single line

            int[] odd = new int[] {1,3,5,7,9};

            Console.WriteLine("1st odd {0}", odd[0]);


            //access the elements using loop
            for(int i=0; i<5; i++)
            {
                Console.WriteLine(odd[i]);
            }

            Console.WriteLine("=========================================");

            //forEach loop 
            foreach(int element in evenNumbers)
            {
                Console.WriteLine(element);
            }


        }


    }
}
