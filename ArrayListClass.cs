using System;
using System.Collections;
using System.Text;

namespace Test
{
    class ArrayListClass
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(123.4);
            arrayList.Add("Madhu");
            foreach(var i in arrayList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
