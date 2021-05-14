using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class BranchingControlStatements
    {
        // This will demonstrate branching control statements like (if, if-else, if-elseif, switch)
        // This Method is Demo for if-else
        // This method checks the given number is even or odd
        public void checkEvenOrOdd(int input)
        {
            if (input % 2 == 0)
            {
                Console.WriteLine("Given number is Even number");
            }
            else
            {
                Console.WriteLine("Given number is Odd number");
            }
        }

        // This Method is Demo for if- elseif
        // This method checks the largest of Three numbers
        public void checkLargestOfThreeNumbers(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("number {0} is largest",num1);
            }
            else if(num2 > num3)
            {
                Console.WriteLine("number {0} is largest", num2);
            }
            else
            {
                Console.WriteLine("number {0} is largest", num3);
            }
        }

        // This method is demo for Switch
        // This method will prints English value for the given number from 1-10  otherwise it will prints Wrong input

        public void printDigitName(int input)
        {
            switch(input)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }


    }
}
