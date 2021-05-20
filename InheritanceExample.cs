using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class InheritanceExample
    {
        public InheritanceExample()
        {
            Console.WriteLine("Iam base class constructor");
        }
        public virtual void say()
        {
            Console.WriteLine("hai");
        }
    }
    

}
