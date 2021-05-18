using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class DictionaryExamples
    {
        //Method for basic dictionary methods
        public void getDictionaryMethids()
        {
            // creating dictionaries
            Dictionary<int, string> dict = new Dictionary<int, string>();
            //Assigning Key Value Pair to the dictionary
            dict.Add(1, "Bhimavaram");
            dict.Add(2, "Thanuku");
            dict.Add(3,"Rajol");

            //Displaying the values

            foreach(KeyValuePair<int,string> i in dict)
            {
                Console.WriteLine($"Key is {i.Key} value is {i.Value}");
            }

            //Modifying the values by using keys
            dict[2] = "Vizag";

            //Check whwther the perticular key is exists or not

            if(dict.ContainsKey(2))
            {
                Console.WriteLine("key is found");
            }
            else
            {
                Console.WriteLine("Key is not found");
            }
            //Method Try get Value
            string result="No";
            if(dict.TryGetValue(5,out result))
            {
                Console.WriteLine(result);
            }
            
        }
    }
}
