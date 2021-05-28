using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Test
{
    class FileOperations
    {
        public static string filePath = @"D:\sample.txt";
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
             using (BinaryWriter sw = new BinaryWriter(fs,Encoding.BigEndianUnicode))
                {
                
                    sw.Write(130);
                    sw.Write("madhu");
                    sw.Write('X');
                    sw.Write(120.45);
                    sw.Write(555);
                    sw.Flush();
                    sw.Close();
                }
            using (BinaryReader sr = new BinaryReader(File.Open(filePath,FileMode.Open,FileAccess.Read),Encoding.BigEndianUnicode))
            {
                Console.WriteLine(sr.ReadInt32());
                Console.WriteLine(sr.ReadString());
                sr.Close();
                

            }
        }
    }
}
