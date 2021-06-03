using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    //where T: struct               The type argument must be a value type.
    //where T: unmanaged            The type of argument must not be a reference type.
    //where T: class                The type argument must be a reference type.
    //where T: new()                The type argument must have a public parameterless constructor.
    //where T: <base class name>	The type of argument must be or derive from the specified base class.
    //where T: <interface name>	    The type argument must be or implement the specified interface.
    
    interface I
    {

    }
    class Sample:I
    {

    }
    class sample1:Sample
    {

    }
    class Constraint<T>  where T : I
    {
        
    }

    class BitArrayClass
    {
        static void Main(string[] args)
        {
            Constraint<Sample> constraint = new Constraint<Sample>();
        }
    }
}
