using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    interface A
    {
        void m1();
    }
    interface B
    {
        void m2();

    }
    class multipleInheritance : A,B
    {
        void A.m1()
        {
            
        }
        void B.m2()
        {

        }

    }
}
