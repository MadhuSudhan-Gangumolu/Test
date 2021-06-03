using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class HashTableClass
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(22);
            linkedList.AddFirst(44);
            linkedList.AddAfter(linkedList.Find(44), 66);
            foreach (var i in linkedList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
