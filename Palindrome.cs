using System;

namespace ExamenNET
{

    public class Palindrome
    {
        /// <summary>
        /// Method in charge of check if a string is a Palindrome or not.
        /// Palindrome is a word who is the same readed from left to right, that right to left
        /// </summary>
        /// <param name="wordToCheck">String to check.</param>
         /// <returns>Boolean (True=Palindrome, False any other case)</returns>
        public bool checkWord(string wordToCheck)
        {
            bool status = false;
            char[] arr = wordToCheck.ToCharArray();
            Array.Reverse(arr);
            var reversed = new string(arr);
            if (wordToCheck.Equals(reversed))
            {
                status = true;
            }
            return status;
        }
    }
}
