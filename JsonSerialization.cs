using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Test
{
    [Serializable]
    class JsonClass
    {
        public int rno { get; set; }
        public string name { get; set; }
        public string location { get; set; }
    }

    class JsonSerialization
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"D:\jsonSerializer.txt";
                JsonClass json = new JsonClass() { rno = 121, name = "naresh", location = "hyderabad" };
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    
                    JsonWriter jsonWriter = new JsonTextWriter(sw);
                    jsonSerializer.Serialize(jsonWriter, json);
                    jsonWriter.Close();

                }

                JsonClass json1;
                using (StreamReader tr = new StreamReader(path))
                {
                    JObject obj = null;
                    JsonReader jsonReader = new JsonTextReader(tr);
                    obj =  jsonSerializer.Deserialize(jsonReader)  as JObject;
                    json1 = obj.ToObject(typeof(JsonClass)) as JsonClass;
                    jsonReader.Close();
                    Console.WriteLine($"id = {json1.rno}\t name = {json1.name}\t location = {json1.location}"); 
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
