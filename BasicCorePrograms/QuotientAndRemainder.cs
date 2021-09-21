using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class QuotientAndRemainder
    {
        public void Division(int dividend, int divisor)
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("The Quotient is" + quotient + "\nThe remainder is" + remainder);
        }
    }
}
