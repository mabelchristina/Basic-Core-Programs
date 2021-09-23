using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Factors
    {
        public void PrimeFactors(int n)
        {
           
            for (int i = 2; i*i<=n; i++)
            {
                if (n % i == 0)
                {
                    if (i == 2 || i % 2 != 0)
                    {
                        Console.WriteLine("prime factors are:" + i + " ");
                    }
                }
            }
        }
    }
}
