using System;
using System.Collections.Generic;
using System.Text;

//Single inheritance
namespace Test
{
    //Child class
    class SingleInheritance : BaseClass
    {
        public void display()
        {
            base.print();
        }
        static void Main(string[] args)
        {
            SingleInheritance b =(SingleInheritance) new BaseClass();
            
            
        }
    }
    //Base class
    class BaseClass
    {
        public int x = 30;
        public void print()
        {
            Console.WriteLine($"X value is {x}");
        }
    }

}
