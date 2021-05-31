using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class BaseA
    {
        public BaseA()
        {
            Console.WriteLine("Base class constructure");
        }
        //<MethodOverloading>
        public void sum(int a, int b)
        {
            Console.WriteLine($"a + b = {a + b}");
        }

        public void sum(int a, int b, int c)
        {
            Console.WriteLine($"a + b + c = {a + b + c}");
        }

        //</MethodOverloading>

        //<MethodOverRiding>
        public virtual void display()
        {
            Console.WriteLine("This is base class");
        }
        //</MethodOverRiding>
    }
    class PolymorphimExample : BaseA
    {
        public PolymorphimExample()
        {
            Console.WriteLine("Child class Constructure");
        }
        public override void display()
        {
            Console.WriteLine("This is child class");
            
        }
        static void Main(string[] args)
        {
            BaseA b = new BaseA();
            PolymorphimExample i = new PolymorphimExample();
            b.sum(10, 20);
            b.sum(10, 20, 30);
            i.display();
            b.display();
        }
    }

    class Base
    { 
        public Base()
        {
            Console.WriteLine("Base class constructure");
        }
        //<MethodOverloading>
        public void sum(int a , int b)
        {
            Console.WriteLine($"a + b = {a+b}");
        }

        public void sum(int a, int b, int c)
        {
            Console.WriteLine($"a + b + c = {a + b + c}");
        }

        //</MethodOverloading>

        //<MethodOverRiding>
        public virtual void display()
        {
            Console.WriteLine("This is base class");
        }
        //</MethodOverRiding>
    }

}
