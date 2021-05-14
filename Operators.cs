using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Operators
    {
        // This Method will do the simple arihemetic operations like (+, -, *, /, %)
        public void arithmeticOperations(int a, int b)
        {
            Console.WriteLine("------------------Arithemetic operators----------------");
            Console.WriteLine("Addition Operations :{0} + {1} = {2}",a,b,(a+b));
            Console.WriteLine("Subtraction Operations :{0} - {1} = {2}", a, b, (a - b));
            Console.WriteLine("Multiplication Operations :{0} * {1} = {2}", a, b, (a * b));
            Console.WriteLine("Division Operations :{0} / {1} = {2}", a, b, (a / b));
            Console.WriteLine("Mod Div Operations :{0} % {1} = {2}", a, b, (a % b));

        }

        // This method will do the Relational Opeations like (==, <=, >=, <, >, !=)
        public void relationalOperations(int a, int b)
        {
            Console.WriteLine("---------------Relational operators------------------");

            Console.WriteLine("{0} < {1} = {2}",a,b,(a < b));
            Console.WriteLine("{0} > {1} = {2}", a, b, (a > b));
            Console.WriteLine("{0} == {1} = {2}", a, b, (a == b));
            Console.WriteLine("{0} <= {1} = {2}", a, b, (a <= b));
            Console.WriteLine("{0} >= {1} = {2}", a, b, (a >= b));
            Console.WriteLine("{0} != {1} = {2}", a, b, (a != b));
        }

        // this method will do Logical operations like (&&, ||, !)
        public void logicalOperations(int a, int b)
        {
            Console.WriteLine("---------------Logical Operators------------------");
            Console.WriteLine("Logical AND is {0} && {1} = {2}",(a<b),(a>b),((a < b) && (a > b)));
            Console.WriteLine("Logical Or is {0} || {1} = {2}", (a < b), (a > b), ((a < b) || (a > b)));
         
        }

        // This method will do Bitwise operations like (&, |, ^, ~, <<, >>)
        public void bitwiseOperations(int a, int b)
        {
            Console.WriteLine("---------------Bitwise Operators------------------");
            Console.WriteLine("Bitwise AND is {0} & {1} = {2}",a,b,(a & b));
            Console.WriteLine("Bitwise OR is {0} | {1} = {2}", a, b, (a | b));
            Console.WriteLine("Bitwise XOR is {0} ^ {1} = {2}", a, b, (a ^ b));
            Console.WriteLine("Bitwise Tlide is ~{0} = {1} ", b, ( ~b));
            Console.WriteLine("Bitwise Left Shift is {0} << 2 =  {1}", a,(a << 2));
            Console.WriteLine("Bitwise RightShift is {0} >> 2 = {1}", a, (a >> 2));

        }

        //This method will do Assignment Operations like ( =, +=, -=, /=, *=, %=, <<=, >>=, &=, |=, ^=)
        public void assignmentOperations(int a, int b)
        {
            Console.WriteLine("---------------Assignment Operators------------------");
            Console.WriteLine(" {0} = {1}   a = {2}",a,2, (a=2));
            Console.WriteLine(" {0} += {1}  a = {2}", a, 2, (a+=2));
            Console.WriteLine(" {0} -= {1}   a = {2}", a, 2, (a-=2));
            Console.WriteLine(" {0} /= {1}    a = {2}", a, 2, (a /= 2));
            Console.WriteLine(" {0} *= {1}    a = {2}", a, 2, (a *= 2));
            Console.WriteLine(" {0} %= {1}    a = {2}", a, 2, (a %= 2));
            Console.WriteLine(" {0} <<= {1}  a = {2} ", a, 2, (a <<= 2));
            Console.WriteLine(" {0} >>= {1}  a = {2}", a, 2, (a >>= 2));
            Console.WriteLine(" {0} &= {1}    a = {2}", a, 2, (a &= 2));
            Console.WriteLine(" {0} |= {1}    a = {2}", a, 2, (a |= 2));
            Console.WriteLine(" {0} ^= {1}    a = {2}", a, 2, (a ^= 2));

        }
    }
}
