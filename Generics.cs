using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    
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
    }
}
