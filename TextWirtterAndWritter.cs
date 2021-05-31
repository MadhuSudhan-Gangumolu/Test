using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Test
{
    class TextWirtterAndWritter
    {
        
        static void Main(string[] args)
        {
            string  file = @"E:\sample3.txt";
            using (TextWriter tw = File.AppendText(file))
            {
                tw.WriteLine("hai");
                tw.WriteLine("madhu");
                tw.Flush();
                tw.Close();
                Console.WriteLine("Data inserted");
            }
            using (TextReader tr = File.OpenText(file))
            {
                string line;
                while((line = tr.ReadLine())!=null)
                {
                    Console.WriteLine(line);
                }
                
            }
        }
    }
}
