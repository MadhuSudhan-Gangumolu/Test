using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class StringExample
    {
        static void Main()
        {
            string s = "madhu";
            Console.WriteLine("String is {0}",s);
            Console.WriteLine("String length is : {0}",s.Length);
            Console.WriteLine("Sub string is {0}",s.Substring(1,3));
            
        }
    }
}
