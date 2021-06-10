using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Test
{
    class MultiThreading
    {
        public static void Method1()
        {
            for(int i = 0;i<50;i++)
            {
                Console.WriteLine("Method 1 : "+i);
            }
        }
        public static void Method2()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Method 2 : " + i);
                if (i ==25)
                {
                    Thread.Sleep(6000);
                }
            }
        }
        public static void Method3()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Method 3 : " + i);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            Thread t3 = new Thread(Method3);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Exiting main thread");
        }
    }
}
