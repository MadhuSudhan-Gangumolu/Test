using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class LoopingStatements
    {
        // This is demo function for printing numbers within its range
        public void printNumbers(int range)
        {
            for (int i = 1; i <= range; i++)
            {
                Console.WriteLine(i);
            }
        }

        // this will prints the even numbers with in the range
        public void printEvenNumbers(int range)
        {
            int i = 1;
            while(i <= range)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        // This method will check the Prime number
        public bool checkPrime(int input)
        {
            int count = 2;
            int inputSquareRoot = (int)Math.Sqrt(input);
            if (input <= 1)
            {
                return false;
            }
            for (int i = 2; i <= inputSquareRoot;i++)
            {
                if (input % i == 0)
                {
                    count += 1;
                    break;
                }

            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
