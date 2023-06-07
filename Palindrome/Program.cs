using System;

namespace Palindrome
{

    /// <summary>
    /// Represents the main program class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method that checks if arguments are palindromes.
        /// </summary>
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                bool isPalindrome = IsPalindrome(arg);
                Console.WriteLine($"{arg} -> {isPalindrome}");
            }
        }

        // Check if string is palindrome using boolean
        static bool IsPalindrome(string str)
        {
            // Check if string is null
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            // Check if string has < 2 length
            if (str.Length < 2)
            {
                return true;
            }

            // Call local function to check if string is palindrome
            return IsPalindromeRecursive(str, 0, str.Length - 1);
        }

        /// <summary>
        /// Checks if string is palindrome.
        /// </summary>
        static bool IsPalindromeRecursive(string str, int start, int end)
        {
            if (start >= end)
            {
                return true;
            }

            /* Check if characters at start and end of string are different, 
            thus string is not palindrome*/
            if (str[start] != str[end])
            {
                return false;
            }

            // Call function to check remaining characters of string
            return IsPalindromeRecursive(str, start + 1, end - 1);
        }
    }
}