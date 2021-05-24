using System;
using System.Collections.Generic;
using System.Text;
using Desk;

namespace Test
{
    // Test1 By default all methods are accessable to with in the class in the same project
    public class Test1
    {
        private protected static int a;
        public void publicMethod()
        {
            Console.WriteLine("Public method");
        }
        private void privateMethod()
        {
            Console.WriteLine("Private Method");
        }
        protected void protectedMethod()
        {
            Console.WriteLine("Protected method");
        }
        internal void internalMethod()
        {
            Console.WriteLine("Internal method");
        }
        protected internal void protectedInternalMethod()
        {
            Console.WriteLine("Protected Internal Method");
        }
        
        private protected void privateProtectedMethod()
        {
            Console.WriteLine("Private Protected Method");
        }

        static void Main()
        {
            Test1 t = new Test1();
            t.internalMethod();
            t.privateMethod();
            t.privateProtectedMethod();
            t.protectedInternalMethod();
            t.protectedMethod();
            t.publicMethod();
        }
        
    }
 
}
