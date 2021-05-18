namespace Test
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {
            //// Operators Example
            //Operators op = new Operators();
            //op.arithmeticOperations(100, 20);
            //op.logicalOperations(100, 20);
            //op.relationalOperations(100, 20);
            //op.bitwiseOperations(100, 20);
            //op.assignmentOperations(100, 20);
            //Console.WriteLine("--------------------------------------------------");
            ////Branching Control statements Examples
            //BranchingControlStatements branch = new BranchingControlStatements();
            //branch.checkEvenOrOdd(10);
            //branch.checkLargestOfThreeNumbers(10, 20, 30);
            //branch.printDigitName(5);
            //Console.WriteLine((int)Math.Sqrt(26));
            //Console.WriteLine("-----------------------------------------------------");
            ////Looping control statements Examples
            //LoopingStatements loopings = new LoopingStatements();
            //loopings.printEvenNumbers(5);
            //loopings.printNumbers(5);

            //bool status = loopings.checkPrime(1);
            //if (status)
            //{
            //    Console.WriteLine("Given number is prime number");
            //}
            //else
            //{
            //    Console.WriteLine("Given number is Not a prime number");
            //}
            //Console.WriteLine("--------------------------------------------------------------");
            //// Date Formatters Example
            //StringFormatters stringFormatters = new StringFormatters();
            //stringFormatters.getDateFormatters();
            //// String Formatters
            //stringFormatters.getStringFormatters();
            //// Decimal Formatters
            //stringFormatters.getDecimalFormatters();
            //stringFormatters.getCustomFormatters();
            //Console.WriteLine("-------------------------------------------------------------------");
            //MethodsExamples methods = new MethodsExamples();
            //int a = 10;
            //int b = 20;
            //int result;
            //methods.example1(a, b);
            //methods.example2();
            //result = methods.example3();
            //Console.WriteLine("The value of result {0}", result);
            //result = methods.example4(a, b);
            //Console.WriteLine("The value of result {0}", result);
            //methods.example5(ref a, ref b);
            //Console.WriteLine("Changed values of a is {0} and b value is {1}", a, b);
            //methods.example6(out a, out b);
            //Console.WriteLine("Changed values of a is {0} and b value is {1}", a, b);
            //methods.example7(in a, in b);
            //Console.WriteLine("ReadOnly values of a is {0} b value is {1}", a, b);
            //methods.findBiggest(10, 5, 45, 54, 65, 12);
            //Console.WriteLine("------------------------------------------------------------");
            //Console.WriteLine("------------------------Array Examples------------------------");
            //ArrayExamples array = new ArrayExamples();
            //array.get1DArray();
            //array.get2DArray();
            //array.getJaggedArray();

            ListExamples list = new ListExamples();
            list.listMethods();

            //Structure Examples

        }
    }
}