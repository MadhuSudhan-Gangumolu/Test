using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Test2:Test1
    {
        
        static void Main()
        {
            a = 20;
            Test2 t = new Test2();
            t.internalMethod();
            t.privateProtectedMethod();
            t.protectedInternalMethod();
            t.protectedMethod();
            t.publicMethod();
        }
    }
}
