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

            Operators op = new Operators();
            
            op.arithmeticOperations(100, 20);
            op.logicalOperations(100, 20);
            op.relationalOperations(100, 20);
            op.bitwiseOperations(100, 20);
            op.assignmentOperations(100, 20);

        }
    }

}
