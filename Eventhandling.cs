using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Sub2
    {
        
    }
    //Subscriber class
    class Eventhandling
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            publisher.Event_Trigger += new Publisher.SampleDelegate(EventMessage);
            publisher.sum(10, 21);

        }
        public static  void EventMessage()
        {
            Console.WriteLine("event is triggered and delegate is called");
        }
    }

    //Publisher class
    class Publisher
    {
        public delegate void SampleDelegate(); //Creating a delegate
        public event SampleDelegate Event_Trigger; // Creating Event with delegate
        public void sum(int a, int b)
        {
            if ((a+b)%2==0)
            {
                Console.WriteLine((a + b));
                Event_Trigger(); //Event hasbeen raised
            }
            else
            {
                Console.WriteLine((a + b));
            }
        }
    }
}
