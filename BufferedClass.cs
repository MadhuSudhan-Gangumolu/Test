using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Test
{
    class BufferedClass
    {
        public static string filePath = @"D:\sample.txt";
        static void Main(string[] args)
        {

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            using (BufferedStream bs = new BufferedStream(fs))
            {
                byte[] byteArray = Encoding.ASCII.GetBytes("Hello madhu");
                bs.Write(byteArray, 0, byteArray.Length);
                bs.Flush();
                bs.Close();
            }
            
            

        }
    }
}
