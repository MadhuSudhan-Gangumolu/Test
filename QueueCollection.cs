using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Test
{
    class QueueCollection
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("madhu");
            queue.Enqueue("Naresh");
            queue.Enqueue("Mayuri");
            foreach(var i in queue)
            {
                Console.WriteLine(i);
            }
            queue.Dequeue();
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
