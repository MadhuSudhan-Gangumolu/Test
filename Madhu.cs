using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Test
{
    class Madhu
    {
        public static void madhuforloop<T>(T a)
        {
            dynamic x = a;
            IEnumerable ie = x as IEnumerable;
            foreach(var i in ie)
            {
                Console.WriteLine(i);
            }

            
        }
        

        static void Main(string[] args)
        {
            Stack<int> t = new Stack<int>();
            t.Push(10);
            t.Push(55);
            List<int> x = new List<int>() { 10, 20, 30 };
            madhuforloop<Stack<int>>(t);
           
            

            
        }
        
    }
}
