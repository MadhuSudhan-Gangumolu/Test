using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class StackCollection
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            foreach(var i in stack.ToArray())
            {
                Console.WriteLine(i);
            }
            stack.Pop();
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }
           

        }
    }
}
