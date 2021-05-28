using System;
using System.Collections.Generic;
using System.IO;
using System.Text;



namespace Desk
{
    
      class Samples 
      {
        static void Main(string[] args)
        {
            //FileStream fs = null;
            string filePath = @"E:\source\sample1.txt";
            //if(!File.Exists(filePath))
            //{
            //    fs =  File.Create(filePath);
                
            //}
            //fs = File.Open(filePath, FileMode.OpenOrCreate);
            //byte[] bytearray = Encoding.UTF8.GetBytes("Naresh");
            //fs.Write(bytearray, 0, bytearray.Length);
            //fs.Flush();
            //fs.Close();
            

            ////using (StreamReader fs1 = new StreamReader(File.Open(filePath, FileMode.Open), Encoding.ASCII))
            ////{
            ////    Console.WriteLine(fs1.ReadToEnd());
            ////}
            //File.AppendAllText(filePath, "Naresh");
            using (FileStream f = File.OpenWrite(filePath))
            {
                byte[] a = Encoding.UTF8.GetBytes("madhu");
                f.Write(a, 0, a.Length);
                f.Flush();
                StreamWriter sf;
                
            }
            using (FileStream fs = File.OpenRead(filePath))
            {
                byte[] b = new byte[128];
                int x = fs.Read(b, 0, b.Length);
                Console.WriteLine(Encoding.UTF8.GetString(b,0,x));
            }
            

        }

      }

}