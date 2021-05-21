using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
   public partial class PartialClass
    {
        public void sayHi()
        {
            Console.WriteLine("Hai");
        }
    }
    public partial class PartialClass
    {
        public void sayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
