using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class BaseClassA
    { 
        public virtual void say()
        {
            Console.WriteLine("Class A Virtual method");
        }
        public void demo()
        {
            Console.WriteLine("Class A normal Method");
        }

    }
    class DerivedClassB : BaseClassA
    {
        public override void say()
        {
            Console.WriteLine("Class B Override method");
        }
        public void demo()
        {
            Console.WriteLine("Class B normal Method");
        }
    }

    class InheritanceExample2 : DerivedClassB
    {
        
        
        static void Main(string[] args)
        {
            BaseClassA a = new BaseClassA();
            DerivedClassB b = new DerivedClassB();
            BaseClassA c = new DerivedClassB();
            
            a.say();
            a.demo();
            b.say();
            b.demo();
            c.say();
            c.demo();
            
        }
    }
}
