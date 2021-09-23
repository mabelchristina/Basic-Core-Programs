using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Leap
    {
        public void LeapYear(int year)
        {
            if (year >= 1000 && year <= 9999)
            {
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    Console.WriteLine(year + " is Leap Year");
                else
                    Console.WriteLine(year + " is not a Leap Year");
            }
            else
            {
                Console.WriteLine("Enter a valid year");
                return;
            }
        }
    }
}