using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class SotedListCollection
    {
        static void Main(string[] args)
        {
            SortedList<int, string> keyValuePairs = new SortedList<int, string>();
            keyValuePairs.Add(12, "madhu");
            keyValuePairs.Add(1, "Naresh");
            foreach(KeyValuePair<int,string> i in keyValuePairs)
            {
                Console.WriteLine(i.Key);
            }
        }
    }
}
