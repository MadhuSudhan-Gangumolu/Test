using System;
namespace Test
{
    public struct MyStruct
    {
        public static int number1 { get; set; }
        public static int number2 { get; set; }
        public MyStruct(int number1, int number2)
        {
            MyStruct.number1 = number1;
            MyStruct.number2 = number2;
        }

        public static void addSum()
        {
            Console.WriteLine(number1 + number2);
        }
        public override string ToString() => $"(number 1 = {number1} & number 2 = {number2})";
    }
   
}
