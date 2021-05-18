using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class ListExamples
    {
        //ListMethods
        public void listMethods()
        {
            List<string> list = new List<string>();
            list.Add("Bhimavaram");
            list.Add("Hyderabad");
            list.Add("Mumbai");
            list.Add("Narsapur");

            Console.WriteLine("Elements in List");
            foreach(string s in list)
            {
                Console.WriteLine(s);
            }
            //Addrange Method will convert the Array to the list
            //Creating Array of string
            string[] arr = { "india", "America", "Italy" };
            List<string> list1 = new List<string>();
            list1.AddRange(arr);
            //Displaying the elements in the list1
            foreach(String s in list1)
            {
                Console.WriteLine(s);
            }

            //ReadOnly method will make the list as readonly we cannot modify the list
            IList<String> list2 = list.AsReadOnly();
            //list2.Add("hai");  This will get an eXception

            //Binarysearch Method is used to search the element in O(logn)
            Console.WriteLine($"BinarySearch Example {list.BinarySearch("Mumbai")}");

            //Clear Method will clear the list elements
            Console.WriteLine($" Count the number of elements before clear method : {list1.Count}");
            list1.Clear();
            Console.WriteLine($"After clear method elemets in list are  : {list1.Count}");
            //Contains Mehod is used to check the list contains the element or not
            Console.WriteLine($"The Bhimavaram is contained in the list or not  : {list.Contains("Bhimavaram")}");

            // Exists Method check the element is present or not it will return boolean

            Console.WriteLine($" Element is exists or not : { list.Exists(x => x.StartsWith("B"))}");

            // Find method will find the first occurence of the element and then prints it

            Console.WriteLine($"The founded element is {list.Find(x=>x.StartsWith("Bhi"))}");

            //FindAll method A list containing all the elements that match the conditions defined by the specified predicate, if found; otherwise, an empty List.

            Console.WriteLine("The founded elements are ");
            foreach(string i in list.FindAll(x => x.Contains("a")))
            {
                Console.WriteLine(i);
            }

            //FindIndex method it check the predicate condition and return the index of first occurence and it returns -ve value if not found
            Console.WriteLine($"The element is fount at {list.FindIndex(x=>x.Contains("X"))}");

            //FindLastIndex will returns the last index of the Element
            Console.WriteLine($"The element is fount at {list.FindLastIndex(x => x.Contains("a"))}");

            //FindLast will returns the last Element of the search
            Console.WriteLine($"The last Serch Elemet is  {list.FindLast(x => x.Contains("a"))}");

            //GetRange method will return the shallow copy of the elements with a specified range
            foreach (string i in list.GetRange(1, 3))
            {
                Console.WriteLine(i);
            }
            //IndexOf method will return the index of particular element IndexOf(ele) , IndexOf(ele,startInd), IndexOf(ele, StratInd,EndInd)
            Console.WriteLine(list.IndexOf("Bhimavaram", 1,3));

            //Insert will add the elements in a specified location
            list.Insert(1, "Rajastan");
            Console.WriteLine("String Rajastan is inserted at location 1");

            //Insert an array in list with the specified range
            string[] input = { "Japan", "China","Bhimavaram" };
            list.InsertRange(3, input);

            //LastIndexOf will return the last Occurence of the finding element

            Console.WriteLine($"Last index of element{list.LastIndexOf("Bhimavaram")}");

            //Remove method will be used to remove the element
            Console.WriteLine($"The element is removed in list {list.Remove("China")}");

            //We can remove the all the matched predicate elements
            Console.WriteLine($"The predicated elements are removed {list.RemoveAll(x=>x.Contains("Bh"))}");

            //we can remove the elements with the specified index
           list.RemoveAt(0);

            //We can remove the elements with the range
            list.RemoveRange(2, 2);

            //Reverse of the list elements
            list.Reverse();
            Console.WriteLine("After reversing the elements the list elements will be");
            foreach(string s in list)
            {
                Console.WriteLine(s);
            }
            //Sorted of list elements
            list.Sort();
            Console.WriteLine("After Sorting the elements the list elements will be");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

        }
    }
}
