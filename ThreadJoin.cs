using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Test
{
    class ThreadJoin
    {
        static int count1;
        static int count2;
        public static  void Counter1()
        {
            while(true)
            {
                count1++;
            }
        }
        public static void Counter2()
        {
            while (true)
            {
                count2++;
            }
        }

        public static void Increment1()
        {
            long i = 0;
            for (i =0;i<1000000000;i++)
            {

            }
            Console.WriteLine("Increment 1 count : "+i);
        }
        public static void Increment2()
        {
            long i = 0;
            for ( i = 0; i < 1000000000; i++)
            {

            }
            Console.WriteLine("Increment 2 count : " + i);
        }
        public  void LockingExample()
        {
            lock (this)
            {
                Console.Write(" This is");
                Thread.Sleep(5000);
                Console.WriteLine(" madhu");
            }
            
        }
        public static void Method1()
        {
            Console.WriteLine("Method 1 is started");
            for (int i =0;i<60;i++)
            {
                Console.WriteLine("Method 1 : "+i);
                Console.WriteLine("Method 1 Thread goes to sleep");
                if(i==25)
                    Thread.Sleep(15000);
                Console.WriteLine("Method 1 Thread awake");
            }
            Console.WriteLine("Exiting from the Method 1");
        }
        public static void Method2()
        {
            Console.WriteLine("Method 2 is started");
            for (int i = 0; i < 60; i++)
            {
                Console.WriteLine("Method 2 : " + i);
                Console.WriteLine("Method 2 Thread goes to sleep");
                if (i == 25)
                    Thread.Sleep(6000);
                Console.WriteLine("Method 2 Thread awake");
            }
            Console.WriteLine("Exiting from the Method 2");
        }
        public static void Method3()
        {
            Console.WriteLine("Method 3 is started");
            for (int i = 0; i < 60; i++)
            {
                Console.WriteLine("Method 3 : " + i);
                Console.WriteLine("Method 3 Thread goes to sleep");
                if (i == 25)
                    Thread.Sleep(6000);
                Console.WriteLine("Method 3 Thread awake");
            }
            Console.WriteLine("Exiting from the Method 3");
        }
        static void Main(string[] args)
        {
            ThreadJoin threadJoin = new ThreadJoin();
            //Console.WriteLine("Main Thread is started");
            //ThreadStart threadStart = Method1;
            //Thread t1 = new Thread(threadStart);
            //Thread t2 = new Thread(Method2);
            //Thread t3 = new Thread(Method3);
            //t1.Start();t2.Start();t3.Start();
            //t1.Join(3000);
            //t2.Join();
            //t3.Join();
            //Console.WriteLine("Exiting Main Thread");

            //Thread t1 = new Thread(threadJoin.LockingExample);
            //Thread t2 = new Thread(threadJoin.LockingExample);
            //Thread t3 = new Thread(threadJoin.LockingExample);
            //t1.Start(); t2.Start(); t3.Start();


            //Thread t1 = new Thread(Counter1);
            //Thread t2 = new Thread(Counter2);
            //t1.Priority = ThreadPriority.Highest;
            //t2.Priority = ThreadPriority.Lowest;
            //t1.Start();
            //t2.Start();

            //Thread.Sleep(5000);
            //Console.WriteLine(count1);
            //Console.WriteLine(count2);


            Stopwatch stopwatch1 = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();
            Thread t1 = new Thread(Increment1);
            Thread t2 = new Thread(Increment2);
            stopwatch2.Start();
            Increment1();
            Increment2();
            stopwatch2.Stop();

            stopwatch1.Start();
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            
            stopwatch1.Stop();
            Console.WriteLine("Time taken by the Multiple Threads"+stopwatch1.ElapsedMilliseconds);
            Console.WriteLine("Time taken by the single  Thread" + stopwatch2.ElapsedMilliseconds);


        }
    }
}
