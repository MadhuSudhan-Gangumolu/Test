using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class InheritanceExample2 : InheritanceExample
    {
        public override void say()
        {
            base.say();
            Console.WriteLine("Iam derived class");
        }
    }
}
