using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public  enum DayExample
    { 
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    class Enums
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The default starting value of enum is {0}", (int)DayExample.Monday);
            Console.WriteLine("We can get the enum values with the help of indexes {0}",(DayExample)2);
            Console.WriteLine("Loop through the values of enum are");
            foreach(DayExample day in Enum.GetValues(typeof(DayExample)))
            {
                Console.WriteLine($"Value is {day}");
            }
            Console.WriteLine("Comparing the enum values");
            DayExample d1 = DayExample.Monday;
            DayExample d2 = DayExample.Thursday;
            Console.WriteLine(d1.CompareTo(d2)>0?"Yes":"No");


        }
    }
}
