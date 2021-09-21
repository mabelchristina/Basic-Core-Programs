using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
   
    class FlipCoin
    {
        int head = 0, tail = 0, headpercentage, tailpercentage;
        public void Flip(int N)
        {
            for(int i=0;i<N;i++)
            {
                Random random = new Random();
                if (random.NextDouble() > 0.5)
                    this.head++;
                else
                    this.tail++;
                N--;
            }
            this.headpercentage = (this.head / N) * 100;
            this.tailpercentage = (this.tail / N) * 100;
            Console.WriteLine("Percentage of getting head " + headpercentage);
            Console.WriteLine("Percentage of getting tail " + tailpercentage);
        }
    }
}
