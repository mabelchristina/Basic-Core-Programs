using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PowerOfTwo
    {
        public void PowerofNumber(int number)
        {
            while (number >= 0)
            {
                Console.WriteLine("Power of "+ number +"is "+Math.Pow(2, number));
                number--;
            }
        }
    }
}
