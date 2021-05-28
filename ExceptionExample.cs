using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class DivideByNegetiveNumberException : ApplicationException
    {
        public  override string Message
        {
            get
            {
                return "Attempt to divide by negetive number.";
            }
        }
    }

    class ExceptionExample
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                if (n2 < 0)
                {
                    throw new DivideByNegetiveNumberException();
                }
                Console.WriteLine("The Result is "+result);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch(FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch(DivideByNegetiveNumberException ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            finally
            {
                Console.WriteLine("The end of the program");
            }
        }

    }
}
