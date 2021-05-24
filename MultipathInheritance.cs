using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    interface A
    {

    }
    interface B : A
    {

    }
    interface C : A 
    { 

    }

    class MultipathInheritance : A,B
    {
    }
}
