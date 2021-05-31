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
            //List<string> l = new List<string>();
            //l.Add("madhu");
            //l.Add("madhu");
            //l.Add("madhu");
            //l.Add("madhu");
            //l.Add("madhu");
            //IEnumerable<string> ie = l;
            string filePath = @"E:\sample2.txt";
            //string dest = @"E:\destination\sample.txt";
            //IEnumerable<string> i1= File.ReadLines(filePath);
            //foreach(var i in i1)
            //{
            //    Console.WriteLine(i);
            //}
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
            using (FileStream f = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))

            {
                byte[] a = Encoding.UTF8.GetBytes("madhu gangumolu");
                f.Write(a, 0, a.Length);
                f.Flush();
               


                //}
                //using (FileStream fs = File.OpenRead(filePath))
                //{
                //    byte[] b = new byte[128];
                //    int x = fs.Read(b, 0, b.Length);
                //    Console.WriteLine(Encoding.UTF8.GetString(b,0,x));
                //}

                


                byte[] b = new byte[1024];
                int x = f.Read(b, 0, b.Length);
                Console.WriteLine(Encoding.UTF8.GetString(b, 0, x));


                //using (StreamReader sr = File.OpenText(filePath))
                //{
                //    string line;
                //    while ((line = sr.ReadLine()) != null)
                //    {
                //        Console.WriteLine(line);
                //    }
                //}



            }

        }

    }
}