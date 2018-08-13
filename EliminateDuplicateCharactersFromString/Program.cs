namespace EliminateDuplicateCharactersFromString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var actualName = "ManjunathGPadasalagi";
            string nonDuplicateName = null;
            for (var actualNamePointer = 0; actualNamePointer < actualName.Length; actualNamePointer++)
            for (var nonDuplicateNamePointer = 0; nonDuplicateNamePointer <= actualNamePointer; nonDuplicateNamePointer++)
                if (nonDuplicateNamePointer == actualNamePointer)
                    nonDuplicateName = nonDuplicateName + actualName[actualNamePointer];
                else if (actualName[actualNamePointer] == actualName[nonDuplicateNamePointer])
                    break;


            var PalindromeObject = new Palindrome();
            var palindrome = PalindromeObject.GetPalindrome("Manjunatha");
            var palindromeNumber = PalindromeObject.GetPalindrome(1200345);
        }
    }
}