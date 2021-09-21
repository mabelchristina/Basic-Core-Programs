using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class EvenOrOdd
    {
        public void EvenOdd(int number)
        {
            if(number%2==0)
                Console.WriteLine(number + " is even number");
            else
                Console.WriteLine(number + " is odd number");
        }
    }
}
