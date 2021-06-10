using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public static class ExtendedMethods
    {
        public static string Reverse(this String str)
        {
            string outString = null;
            foreach(char i in str)
            {
                outString = i + outString;
            }
            return outString;
        }
        public static bool IsPrime(this Int32 i)
        {
            int count = 2;
            int rootValue = (int)Math.Sqrt(i);
            if (i<2)
            {
                return false;
            }
            else
            {
                for (int idx = 2; idx <= rootValue; idx++)
                {
                    if (i % idx == 0)
                    {
                        count += 1;
                    }
                    if (count > 2)
                    {
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

        public static bool IsGreaterThan(this Int32 x,int y)
        {
            if(x>y)
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
