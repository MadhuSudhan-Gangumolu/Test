using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class AsynchronousProgramming
    {
        public static async void Method1()
        {
           int response = await Method2();
            Console.WriteLine("the response number is "+response);
        }
        public static Task<int>  Method2()
        {
            
            return Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 1;
            });
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main method started");
            Method1();
            for(int i=0;i<1500;i++)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}
