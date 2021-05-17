using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class ArrayExamples
    {
        // This method will explain the single dimentional array
        public void get1DArray()
        {
            int[] arry = { 10,20,30};
            Console.WriteLine("Elements in the array are");
            foreach(int i in arry)
            {
                Console.WriteLine(i);
            }
            
        }
        //This method will explain the two dimentional array
        public void get2DArray()
        {
            int[,] arr = new int[2, 3] {
                { 1,2,3},
                {4,5,6 }
            };
            Console.WriteLine("Elements in the 2D Array");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

           
        }
        public void getJaggedArray()
        {
            int[][,] arr = new int[2][,];
            arr[0] = new int[2,2]
            {
                { 10,20},
                { 30,40}

            };
            arr[1] = new int[1, 5]
            {
                { 1,2,3,4,5}
            };
            Console.WriteLine("Elements in the jagged Array are ");
            foreach(int[,] i in arr)
            {
                foreach(int j in i)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
