using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Test
{
    class DemoSamples
    {
        static void Main(string[] args)
        {
            string path = @"E:\Sample\mahesh1.txt";
            using (TextReader tw =  File.OpenText(path))
            {
                Console.WriteLine(tw.ReadToEnd());
            }
            
           

        }
    }
}
