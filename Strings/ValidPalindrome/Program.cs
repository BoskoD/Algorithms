//https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/883/
using System;

namespace ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Ana voli Milovana";
            bool validPalindrome = Result.IsValidPalindrome(phrase);
            Console.WriteLine(validPalindrome);
        }
    }

    internal class Result
    {
        internal static bool IsValidPalindrome(string phrase)
        {
            var length = phrase.Length;
            var left = 0;
            var right = length - 1;

            while (left < right) 
            {
                if (!char.IsLetterOrDigit(phrase[left]))
                {
                    left++;
                }
                else if (!char.IsLetterOrDigit(phrase[right]))
                {
                    right--;
                }
                else
                {
                    if (char.ToLower(phrase[left]) != char.ToLower(phrase[right]))
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
            }
            return true;
        }
    }
}