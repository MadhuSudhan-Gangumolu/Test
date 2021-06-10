using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Test
{
    class ArrayListClass
    {
        public static void foreachMadhu<T>(T data)
        {
            //The generic type That will be converted into Specefic type at runtime  
            dynamic text = data;

            //IEnumerator is an interface which will iterate the data
            //For this i will convert into the IEnumerable
            //After that the IEnumerable have a method GetEnumerator which will return the IEnumerator

            IEnumerator t1 = ((IEnumerable)text).GetEnumerator();

            //Movenext() is a method in IEnumerator which will move to the next position and returns true
            //otherwise it returns false
            //for looping purpose goto label is used
            loop:
            
                //check IEnumerator has the next position
                if (t1.MoveNext())
                {

                    // printing the current position of a IEnumerator
                         Console.WriteLine(t1.Current.ToString());
                    //The curser is goes to the line number 26
                    goto loop;
                }
                else
                {
                    //If elements are not exists it will return from the method
                    return;
                }
        }
        static void Main(string[] args)
        {
            //creating ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add(123.4);
            arrayList.Add("Madhu");

            //creating string
            string z = "madhu";

            //creating integer array
            int[] x = { 10,20, 31 };

            //Creating the list
            List<object> a = new List<object>() { "madhu", "Naresh", 2 };
            
            //creating the stack
            Stack s = new Stack();
            s.Push(22);
            s.Push(44);

            //calling the foreachmadhu with generic type object which will accepts the all type because object is the parent of all classes
            foreachMadhu<object>(x);   
        }
    }
}
