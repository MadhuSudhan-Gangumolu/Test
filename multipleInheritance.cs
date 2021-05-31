using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
     class A
    {
        static A()
        {
            Console.WriteLine("Static A");
        }
        public A()
        {
            Console.WriteLine("Noramal A");
        }
    }
    static class B
    {
        
        
        
    }
    class multipleInheritance 
    {
        static void Main(string[] args)
        {
            A a = new A();
            A b = new A();
            //op static A
        }

    }
}
