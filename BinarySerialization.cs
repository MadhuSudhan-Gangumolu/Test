using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Test
{
    [Serializable]
    class Demo12
    {
        public int a { get; set; }
        public float b { get; set; }
        public string c { get; set; }


    }
    class BinarySerialization
    {
        static void Main(string[] args)
        {
            string path = @"D:\sample.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            Demo12 d = new Demo12() { a = 30, b = 14.5f, c = "babu" };
            BinaryFormatter bin = new BinaryFormatter();
            bin.Serialize(fs, d);
            fs.Close();

            FileStream fs1 = new FileStream(path, FileMode.OpenOrCreate);

            Demo12 d1;
            d1 = bin.Deserialize(fs1) as Demo12;
            Console.WriteLine($"{d1.a}  ,{d1.b}, {d1.c}");
        }
    }
}
