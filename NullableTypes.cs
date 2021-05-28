using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class NullableTypes
    {
        static void Main(string[] args)
        {
            // One way to declare nullable types
            Nullable<int> a = null;
            int? b = null;
            // it will return the actual value otherwise it will return the default value
            Console.WriteLine($"{a.GetValueOrDefault()}");
            Console.WriteLine(b.HasValue);
            // Assign nullable type to value types
            int c = b ?? 0;
            Console.WriteLine(c);
        }
    }
}
