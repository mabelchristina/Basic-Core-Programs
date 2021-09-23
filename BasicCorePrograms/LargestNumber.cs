using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class LargestNumber
    {
        public void LargeNumber(int number1,int number2, int number3)
        {
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine(number1 +" is the greatest among three. \n");
                return;
            }
            if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine(number2 +" is the greatest among three \n");
            }
            else
            {
                Console.WriteLine(number3+ " is the greatest among three \n");
            }
        }
    }
}
