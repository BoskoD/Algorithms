//https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/887/
using System;

namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "Bosko", "Borba", "Binary", "Bionic" };
            string longestPrefix = Result.LongestCommonPrefix(words);
            Console.WriteLine($"Longest common prefix is: {longestPrefix}");
        }
    }

    internal class Result
    {
        internal static string LongestCommonPrefix(string[] words)
        {
            if (words.Length == 0 || Array.IndexOf(words, "") != -1) 
            {
                return "";
            }

            string result = words[0];
            int i = result.Length;

            foreach (var word in words)
            {
                int j = 0;

                foreach (var character in word)
                {
                    if (j >= i || result[j] != character) 
                    {
                        break;
                    }
                    j += 1;
                }
                i = Math.Min(i, j);
            }
            return result.Substring(0, i);
        }
    }
}