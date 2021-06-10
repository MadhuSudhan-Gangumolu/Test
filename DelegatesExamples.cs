using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public delegate void delemath(int x, int y);

    //Func for value return type
    //Action for void type
    //Predicate for boolean type
    class DelegatesExamples
    {
        public int addSum(int a, int b, int c)
        {
            return a + b + c;
        }
        public bool largeCheck(int a)
        {
            if (a > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
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
            Func<int, int, int, int> func = de.addSum;
            Console.WriteLine(func.Invoke(10, 20, 30));

            Action<int, int> action = de.sum;
            action.Invoke(10, 20);

            Predicate<int> predicate = de.largeCheck;
            Console.WriteLine(predicate.Invoke(22));

            
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
