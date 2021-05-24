using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class InheritanceExample2 : InheritanceExample
    {
        public InheritanceExample2()
        {
            Console.WriteLine("Iam child");
        }
        public override void say()
        {
            base.say();
            Console.WriteLine("Iam derived class");
            base.hai();
        }
        static void Main(string[] args)
        {
            InheritanceExample2 i = new InheritanceExample2();

        }
    }
}
