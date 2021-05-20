using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Test3 
    {
        static void Main()
        {
            Test2 t = new Test2();
            t.internalMethod();
            t.protectedInternalMethod();
            t.publicMethod();
        }
    }
}
