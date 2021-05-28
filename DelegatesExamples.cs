using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public delegate void delemath(int x, int y);
    class DelegatesExamples
    {
        public void sum(int a, int b)
        {
            Console.WriteLine("the sum of two numbers is {0}", a + b);
        }
        public static  void sub(int a, int b)
        {
            Console.WriteLine("the subtraction  of two numbers is {0}", a - b);
        }
        static void Main(string[] args)
        {
            DelegatesExamples de = new DelegatesExamples();
            delemath d = new delemath(de.sum);
            d.Invoke(10, 20);
            d += sub;
            d.Invoke(10, 30);

            // or
            // Anonymous methods
            delemath d1 = delegate (int x, int y)
            {
                Console.WriteLine("sum is {0}", x + y);
            };
            d1.Invoke(40, 50);

        }
    }
}
