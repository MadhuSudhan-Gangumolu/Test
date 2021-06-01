using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Test
{
    public enum Model
    {
        Petrol,
        Desiel
    };
    public enum Color
    { 
        Red,
        Blue,
        Black,
        Orange,
        Green,
        Yellow,
        Brown
    };


    class Bike
    {
        
        public int serialNumber { get; set; }
        public int modelNumber { get; set; }
        public Color color { get; set; }
        public float price { get; set; }
        public Model model { get; set; }


    }

    class JsonSerializeNormalprocess
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"D:\bike.txt";
                Bike bike = new Bike()
                {
                    serialNumber = 1452145,
                    modelNumber = 4521,
                    color = Color.Red,
                    price = 98575.78f,
                    model = Model.Petrol                                       
                };
                string jsonString = JsonConvert.SerializeObject(bike);
                if(File.Exists(path))
                {
                    File.Delete(path);
                }
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    streamWriter.WriteLine(jsonString);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                using (StreamReader sr = new StreamReader(path))
                {
                    string jsonResonse = sr.ReadToEnd();
                    Bike bike1 = JsonConvert.DeserializeObject<Bike>(jsonResonse);
                    Console.WriteLine($" SerialNumber : {bike1.serialNumber}\n ModelNumber : {bike1.modelNumber}\n Color : {(Color)bike1.color} \n price : {bike1.price}\n Model : {(Model)bike1.model}");


                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
