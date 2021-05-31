using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Test
{
    [Serializable]
    public class Xml
    {
        public string name { get; set; }
        public int id { get; set; }
        public string address { get; set; }
    }
    class XMLSerialization
    {
        static void Main(string[] args)
        {
            Xml x = new Xml() { name = "veeru", id = 12345, address = "Bhimavaram" };
            
            string path = @"D:\sample1.txt";
            StreamWriter sw = new StreamWriter(path);
            XmlSerializer xs = new XmlSerializer(typeof(Xml));
            xs.Serialize(sw, x);
            sw.Close();

            StreamReader sr = new StreamReader(path);
            Xml x1;
            x1 = (Xml) xs.Deserialize(sr);
            sr.Close();
            Console.WriteLine($"Name {x1.name} Id {x1.id}, address {x1.address}");
        }
    }
}
