using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class VowelOrConsonant
    {
        public void VowelConsonant(char ch)
        {
            ch = char.ToLower(ch);
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine( " Given Character is Vowel.");
            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(" Given Character is Consonant.");
            }
            Console.ReadLine();
        }
    }
}
