using System;

namespace EliminateDuplicateCharactersFromString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var actualName = "ManjunathGPadasalagi";

            // Here I have created the object of the main class. Within the same class.
            var ObjectOfMainClass = new Program();
            var nonDuplicateName = ObjectOfMainClass.RemoveDuplicateCharacterFromString(actualName);
            Console.WriteLine(nonDuplicateName);

            var PalindromeObject = new Palindrome();
            var palindrome = PalindromeObject.GetPalindrome("Manjunatha");

            // Static method within the same class
            palindrome = RemoveDuplicateCharacterFromStringStaticMethod("Manjunath");
            var palindromeNumber = PalindromeObject.GetPalindrome(1200345);
        }

        public string RemoveDuplicateCharacterFromString(string actualName)
        {
            string nonDuplicateName = null;
            for (var actualNamePointer = 0; actualNamePointer < actualName.Length; actualNamePointer++)
            for (var nonDuplicateNamePointer = 0; nonDuplicateNamePointer <= actualNamePointer; nonDuplicateNamePointer++)
                if (nonDuplicateNamePointer == actualNamePointer)
                    nonDuplicateName = nonDuplicateName + actualName[actualNamePointer];
                else if (actualName[actualNamePointer] == actualName[nonDuplicateNamePointer])
                    break;
            return nonDuplicateName;
        }

        public static string RemoveDuplicateCharacterFromStringStaticMethod(string actualName)
        {
            string nonDuplicateName = null;
            for (var actualNamePointer = 0; actualNamePointer < actualName.Length; actualNamePointer++)
            for (var nonDuplicateNamePointer = 0; nonDuplicateNamePointer <= actualNamePointer; nonDuplicateNamePointer++)
                if (nonDuplicateNamePointer == actualNamePointer)
                    nonDuplicateName = nonDuplicateName + actualName[actualNamePointer];
                else if (actualName[actualNamePointer] == actualName[nonDuplicateNamePointer])
                    break;
            return nonDuplicateName;
        }
    }
}