using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForPractice
{
    internal class MultiDimention
    {
        //multi-dimentionnal array contains more than one row
        //in c# we also call it as rectangular array coz row length is same
        //creating a two-dimention array

        int[,] twoDimention = new int[3, 2];


        //initilizing the value for 2-dimentional array
        public void InitTwoDimention()
        {
            twoDimention = new int[,] { { 1,2 }, { 3, 4 }, { 5, 6 } };

            //for loop accessing

            for (int i = 0; i<3; i++)
            {
                for(int j = 0; j<2; j++)
                {
                    Console.WriteLine("the elements are: {0}", twoDimention[i,j]);
                }
            }

        }

        //creating three-dimention array

        int[,,] threeDimention = new int[2, 3, 4];
        
        public void ThreeDimention()
        {
            //initilizing the 3 dimention array

            threeDimention = new int[,,] { { { 1, 2, 3, 4 },{ 5,6,7,8},{ 9,10,11,12}}, { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } } };

            //for loop for accessing the elements

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k  = 0; k < 4; k++)
                    {
                        Console.WriteLine("elements of three dimentional array are{0}",threeDimention[i,j,k]);
                    }

                }


            }
        }


        public void JaggedArray()
        {
            //aray of arrays
            //in c# jagged array is an array whos elements are arrays
            //any other way to initilize the array value for a jagged array
            

            int[][] jaggedArray = new int[4][];

            //initilize the value of the jagged array type1
            jaggedArray[0] = new int[] { 1, 2, 3, 4 };
            jaggedArray [1] = new int[] { 5, 6, 7,4,4,10,6,7,8,5};

            //initilize the value of the jagged array type2
            //int[][] jaggerArray = { new int[] { 1, 2, 3, 4, 5,},
            //                           new int[] { 5, 6, 7,4,4,5,} };


            Console.WriteLine(jaggedArray[0][5]);


            //access elements using forloop

            for(int i = 0; i < jaggedArray.Length; i++)
            {
                for(int j=0; j<jaggedArray[i].Length;j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }

        }













    }
}
