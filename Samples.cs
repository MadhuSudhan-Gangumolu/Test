using System;
using System.Collections.Generic;
using System.Text;

namespace Desk
{
    class A
    {
        public void disp()
        {
            Console.WriteLine("Parent class");
        }
    }
     class Samples : A
        {
            public  void disp()
            {
                Console.WriteLine("Child class");
            }
            static void Main()
            {

                A s = new Samples();
                s.disp();
            }

        }

}