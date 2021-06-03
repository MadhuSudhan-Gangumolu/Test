using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public delegate void sampleDelegate(string message);
    class LamdaExpression
    {

        static void Main(string[] args)
        {
            int[] array = { 10, 12, 13, 14, 15 };
            
            List<int> a = new List<int>() { 10, 20, 30, 40, 54, 23 };
            var i = a.FindAll(x => (x % 2) == 0);
            foreach (var j in i)
            {
                Console.WriteLine(j);
            }
            sampleDelegate sample = (message) =>
            {
                Console.WriteLine("Hello "+message);
            };
            sample.Invoke("Madhu");
        }
    }
}
