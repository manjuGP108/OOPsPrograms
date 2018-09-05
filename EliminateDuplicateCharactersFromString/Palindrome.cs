namespace EliminateDuplicateCharactersFromString
{
    internal class Palindrome
    {
        public string GetPalindrome(string actualName)
        {
            string palindromeName = null;
            for (var actualNamePointer = actualName.Length - 1; actualNamePointer >= 0; actualNamePointer--)
                palindromeName = palindromeName + actualName[actualNamePointer];
            return palindromeName;
        }

        public int GetPalindrome(int actualNumber)
        {
            var reveresedNumber = 0;
            while (actualNumber > 0)
            {
                var reminder = actualNumber % 10;
                reveresedNumber = reveresedNumber * 10 + reminder;
                actualNumber = actualNumber / 10;
            }
            return reveresedNumber;
        }
    }
}