using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Test
{
    class DirectoryClass
    {
        static void Main(string[] args)
        {
            String source = @"E:\source";
            String destination = @"E:\destination";
            try
            {
                //var textFiles = Directory.EnumerateFiles(source, "*.txt");
                //foreach (var i in textFiles)
                //{
                //    string file = i.Substring(source.Length + 1);
                //    Directory.Move(i,Path.Combine(destination,file));
                //}
                Directory.CreateDirectory(Path.Combine(source, "madhu"));
                
                Console.WriteLine("Current working directory {0}",Directory.GetCurrentDirectory());
                Console.WriteLine("Entries of a directory");
                foreach (var i in Directory.EnumerateFileSystemEntries(destination,"*.txt"))
                {
                    Console.WriteLine(i);
                }
                Directory.SetCreationTime(destination, DateTime.Now);
                Console.WriteLine("Creation time of a directory {0}",Directory.GetCreationTime(destination));
                foreach (var i in Directory.GetLogicalDrives())
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine(Directory.GetParent(Path.Combine(source,"madhu")));
                

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
