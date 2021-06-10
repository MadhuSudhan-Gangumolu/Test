using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    //where T: struct The type argument must be a value type.
    //where T: unmanaged The type of argument must not be a reference type.
    //where T: class The type argument must be a reference type.
    //where T: new() The type argument must have a public parameterless constructor.
    //where T: <base class name>	The type of argument must be or derive from the specified base class.
    //where T: <interface name>	The type argument must be or implement the specified interface.
    
    public delegate T getDelegate<T>(T a, T b);
    class GenericsSample<T>
    {
        
        public T getSum(T a, T b)
        {
            dynamic x, y;
            x = a;
            y = b;
            return x+y;
        }
        
    }
    class Generics
    {
        

        static void Main(string[] args)
        {
            GenericsSample<float> obj = new GenericsSample<float>();
            getDelegate<float> del = new getDelegate<float>(obj.getSum);
            Console.WriteLine(del.Invoke(12.3f,15.4f));
        }

        private static void foreachmadhu(char v1, object i, string v2)
        {
            throw new NotImplementedException();
        }

        private static void foreachmadhu(object var, object i, string v)
        {
            throw new NotImplementedException();
        }
    }
}
