using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliminateDuplicateCharactersFromString
{
    class Palindrome
    {
        public string GetPalindrome(string actualName)
        {
            string palindromeName = null;
            for (int actualNamePointer = actualName.Length-1 ; actualNamePointer >= 0; actualNamePointer--)
            {
                palindromeName = palindromeName + actualName[actualNamePointer];

            }
            return palindromeName;
        }

        public int GetPalindrome(int actualNumber)
        {
            int reveresedNumber = 0;
            while (actualNumber>0)
            {
                int reminder = actualNumber % 10;
                reveresedNumber = reveresedNumber * 10 + reminder;
                actualNumber = actualNumber / 10;
            }
            return reveresedNumber;
        }
    }
}
