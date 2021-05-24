using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class A
    {
        public void m1()
        {
            Console.WriteLine("Class A");
        }
    }
    class B : A
    {
        public void m2()
        {
            Console.WriteLine("Class B");
        }
    }
    class MultilevelInheritance : B
    {
        public void m3()
        {
            Console.WriteLine("child of B");
        }
    }
    
}
