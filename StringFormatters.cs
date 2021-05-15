using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class StringFormatters
    {
        // Date Formatters
        public void getDateFormatters()
        {
            Console.WriteLine("-------------------------Date Formatters----------------------------");
            Console.WriteLine("Short date {0:d}",DateTime.Now);// o/p : 5/15/2021
            Console.WriteLine("Day with zero-padded {0:dd}", DateTime.Now);// o/p : 15
            Console.WriteLine("Short day name {0:ddd}", DateTime.Now);// o/p : Sat
            Console.WriteLine("Full day name {0:dddd}", DateTime.Now);// o/p : Saturday
            Console.WriteLine("Long date  {0:D}", DateTime.Now);// o/p : Saturday, May 15, 2021
            Console.WriteLine("Full date and time, short {0:f}", DateTime.Now);// o/p : Saturday, May 15, 2021 12:02 PM
            Console.WriteLine("Full date and time, long {0:F}", DateTime.Now);// o/p : Saturday, May 15, 2021 12:02:15 PM
            Console.WriteLine("Default date and time  {0:g}", DateTime.Now);// o/p : 5/15/2021 12:04 PM
            Console.WriteLine("Era {0:gg}", DateTime.Now);// o/p : A.D
            Console.WriteLine("Hour (2 digits, 12H)  {0:hh}", DateTime.Now);// o/p : 12
            Console.WriteLine("Hour (2 digits, 24H) {0:HH}", DateTime.Now);// o/p : 12
            Console.WriteLine("Month and day  {0:M}", DateTime.Now);// o/p : May 15
            Console.WriteLine("Minutes, zero-padded  {0:mm}", DateTime.Now);// o/p : 07
            Console.WriteLine("Month, zero-padded {0:MM}", DateTime.Now);// o/p : 05
            Console.WriteLine("3-letter month name {0:MMM}", DateTime.Now);// o/p : May
            Console.WriteLine("Full month name {0:MMMM}", DateTime.Now);// o/p : may
            Console.WriteLine("Sortable date string {0:s}", DateTime.Now);// o/p : 2021-05-15T12:10:14
            Console.WriteLine("Short time {0:t}", DateTime.Now);// o/p : 12:11 PM
            Console.WriteLine("Long time {0:T}", DateTime.Now);// o/p : 12:12:45 PM
            Console.WriteLine("AM/PM {0:tt}", DateTime.Now);// o/p : PM
            Console.WriteLine("Universal GMT {0:U}", DateTime.Now);// o/p : Saturday, May 15, 2021 9:30:14 AM
            Console.WriteLine("year & Month {0:Y}", DateTime.Now);// o/p : May 2021
            Console.WriteLine("2 digit year {0:yy}", DateTime.Now);// o/p : 21
            Console.WriteLine("4 digit year {0:YYYY}", DateTime.Now);// o/p : 2021   

        }
        // This method will give you the basic string formats
        public void getStringFormatters()
        {
            Console.WriteLine("--------------------String Formatters------------------");

            Console.WriteLine("Basic String formatter printing value of a is {0}",121);
            Console.WriteLine("LEFT: string: ->{0,-15}<- int: ->{1,-15}<-", "abc", 123);
            Console.WriteLine("RIGHT: string: ->{0,15}<- int: ->{1,15}<-", "abc", 123);
        }

        // This method will give you the basic decimal formats
        public void getDecimalFormatters()
        {
            Console.WriteLine("--------------------------- Decimal Formatters---------------------");
            Console.WriteLine("Currency Format with 2 scale {0:c}", 75674.73789621);
            Console.WriteLine("Currency Format with 3 scale {0:c3}", 75674.73789621);
            Console.WriteLine("Currency Format with 4 scale {0:c4}", 75674.73789621);
            Console.WriteLine("Decimal number with scientific notation {0:e}", 75674.73789621);
            Console.WriteLine("Decimal number with the fixed notation {0:f3}", 75674.73789621);
            Console.WriteLine("Decimal number with the general notation {0:g}", 75674.73789621);
            Console.WriteLine("Number with thousand seperator  {0:n}", 75674.73789621);


        }

        // This method will give you the basic Custom Formatters
        public void getCustomFormatters()
        {
            Console.WriteLine("--------------------------------Custom Formatters------------------------------");
            Console.WriteLine("{0:0000}",123);// o/p : 0123
            Console.WriteLine("{0:0.00}",123);// o/p : 123.00
            Console.WriteLine("{0:##.###}",1.23456);
            Console.WriteLine("{0:(##)-###}",9550023);
            Console.WriteLine("{0:##-##-###}",9550023446);
            Console.WriteLine("'{0,6:#.###}'",.124);
            Console.WriteLine("{0:0%}",0.25);
        }
    }
}
