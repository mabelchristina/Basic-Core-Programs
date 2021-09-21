using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.FlipCoin \n");
            int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Flip(Convert.ToInt32(Console.ReadLine()));
                    break;
                //case 2:
                 //   FlipCoin flipCoin1 = new FlipCoin();
                  //  fl
            }

        }
    }
}
