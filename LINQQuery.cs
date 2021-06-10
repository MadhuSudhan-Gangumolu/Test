using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Test
{
    
    class LINQQuery
    {
        static List<int> a = new List<int>() { 10, 20, 12, 13, 1, 45, 46, 47, 48, 49, 52, 45, 21, 13, 45, 89 };
        
        public static void LinqQuery()
        {
            
            var data = from i in a where i % 2 == 0 select i;
            foreach (int j in data)
            {
                Console.WriteLine(j);
            }
            
        }

        public static void LiqnMethodQuery()
        {
            var data = a.Where(obj => obj % 2 == 0).ToList();
            foreach (int j in data)
            {
                Console.WriteLine(j);
            }

        }

        public static void MixedLinq()
        {
            var data = (from i in a where i % 2 == 0 select i).Sum();
            Console.WriteLine("Sum of all even numbers : "+data);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
