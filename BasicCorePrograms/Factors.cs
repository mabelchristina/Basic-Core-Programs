using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Factors
    {
        public void PrimeFactors(int n)
        {
            while (n % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.WriteLine("prime factors are:"+ i + " ");
                    n /= i;
                }
            }
            if (n > 2)
            {
                Console.WriteLine("prime factors are:"+ n);
            }
        }
    }
}
