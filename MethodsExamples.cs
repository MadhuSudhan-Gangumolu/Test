using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class MethodsExamples
    {
        public MethodsExamples()
        {
            Console.WriteLine("-----------------------Methods Example--------------------");
        }
        // This Methods has no return type and accept the arguments
        public void example1(int a, int b)
        {
            Console.WriteLine("The Method with no return type and accept arguments  sum is {0}",(a+b));

        }
        // This Method has no return type and no arguments
        public void example2()
        {
            Console.WriteLine("The Method has no return type and no arguments");

        }
        //This Method with return type and  no arguments
        public int example3()
        {
            return 0;
        }
        //This method with return type and accepts arguments
        public int example4(int a, int b)
        {
            return a + b;
        }
        //This method will accepts the referenced arguments.
        //When the arguments are changed in the method it will reflects  to the actual arguments
        public void example5(ref int a, ref int b)
        {
            Console.WriteLine("The parameter argumets are changed  a to 22 and b to 40");
            a = 22;
            b = 40;
        }
        //This method will accepts the out arguments.
        //The passed arguments will not be used and we need to initilize the arguments the values the will reflects on actual arguments
        public void example6(out int a, out int b)
        {
            Console.WriteLine("a value will be changed to 11 and b value will be 22");
            a = 11;
            b = 22;
        }
        //This method will accepts the arguments.
        //The passed arguments will be used but changing is not enable. We can use it as a readonly arguments
        public void example7(in int a, in int b)
        {
            Console.WriteLine("The values of A is {0} and value of b is {1}",a,b);
        }
        // This method will accepts the n number of integer arguments
        public void findBiggest(params int[] a)
        {
            int big = 0;
            foreach(int i in a)
            {
                if (i > big)
                {
                    big = i;
                }
            }
            Console.WriteLine("The biggest element is {0}",big);
        }

    }
}
