using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class SwapNumbers
    {
        public void Swap(int a,int b)
        {
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;      
            b = a / b;     
            a = a / b;     
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}
