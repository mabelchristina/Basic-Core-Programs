using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
   
    class FlipCoin
    {
        double head = 0, tail = 0;
        public void Flip(int N)
        {
            Random random = new Random();
            for (int i=0;i<N;i++)
            {
                if (random.NextDouble() < 0.5)
                   this.tail++;
                else
                   this.head++;
            }
            Console.WriteLine("Percentage of getting head " + (head / N * 100)+ " %");
            Console.WriteLine("Percentage of getting tail " + (tail / N * 100)+ " %");
        }
    }
}
