using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Test
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Operators Example
            Operators op = new Operators();
            op.arithmeticOperations(100, 20);
            op.logicalOperations(100, 20);
            op.relationalOperations(100, 20);
            op.bitwiseOperations(100, 20);
            op.assignmentOperations(100, 20);
            Console.WriteLine("--------------------------------------------------");
            //Branching Control statements Examples
            BranchingControlStatements branch = new BranchingControlStatements();
            branch.checkEvenOrOdd(10);
            branch.checkLargestOfThreeNumbers(10, 20, 30);
            branch.printDigitName(5);
            Console.WriteLine((int)Math.Sqrt(26));
            Console.WriteLine("-----------------------------------------------------");
            //Looping control statements Examples
            LoopingStatements loopings = new LoopingStatements();
            loopings.printEvenNumbers(5);
            loopings.printNumbers(5);

            bool status = loopings.checkPrime(1);
            if (status)
            {
                Console.WriteLine("Given number is prime number");
            }
            else
            {
                Console.WriteLine("Given number is Not a prime number");
            }
            Console.WriteLine("--------------------------------------------------------------");
            // Date Formatters Example
            StringFormatters stringFormatters = new StringFormatters();
            stringFormatters.getDateFormatters();




        }
    }

}
