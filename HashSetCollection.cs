using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class HashSetCollection
    {
        static void Main(string[] args)
        {
            HashSet<int> hashset = new HashSet<int>();
            hashset.Add(25);
            hashset.Add(25);
            foreach(var i in hashset)
            {
                Console.WriteLine(i);
            }
        }
    }
}
