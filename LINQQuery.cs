using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Test
{
    class LINQQuery
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 12, 13, 1, 45, 46, 47, 48, 49, 52, 45, 21, 13, 45, 89 };
            var data = from i in a where i % 2 == 0 select i;
            foreach(int j in data)
            {
                Console.WriteLine(j);
            }
        }
    }
}
