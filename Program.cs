using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Test
{
    
    class Program
    {
        

        static void Main(string[] args)
        {
            var s = "String";
        }
    }
   
    public class A
    {
        public A()
        {

            Console.WriteLine("This is base class");
        }
        public virtual string getname()
        {
            return "madhu";
        }
        public virtual void run()
        {
            
        }
        
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("This is derived class");
        }
        public void display()
        {
            Console.WriteLine(base.getname());
        }
        public sealed override void run()
        {

        }
    }
    class C : A
    {
        public override void run()
        {
            
        }

    }
    

}
