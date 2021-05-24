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
        public InheritanceExample(int a)
        {
            Console.WriteLine("Iam base class parameter constructor");
        }
        protected void hai()
        {

        }
        public virtual void say()
        {
            Console.WriteLine("hai");
        }
    }
    

}
