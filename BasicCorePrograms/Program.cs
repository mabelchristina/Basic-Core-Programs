using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.FlipCoin \n2.LeapYear \n3.Power of Two \n");
            int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Flip(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 2:
                    Leap leapyear = new Leap();
                    leapyear.LeapYear(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 3:
                    PowerOfTwo power = new PowerOfTwo();
                    power.PowerofNumber(Convert.ToInt32(Console.ReadLine()));
                    break;  

            }

        }
    }
}
