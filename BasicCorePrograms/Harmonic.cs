using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Harmonic
    {
        public void HarmonicValue(int n)
        {
            float harmonic = 1;
            for (int i = 2; i <= n; i++)
            {
                if (i <= n)
                Console.WriteLine("[1/" + i+"]+");
                harmonic += (float)1 / i;
            }
            Console.WriteLine("Harmonic Value of "+ n +" is " +harmonic);
        }

    }
}
