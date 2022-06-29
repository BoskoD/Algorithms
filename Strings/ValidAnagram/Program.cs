//https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/882/
using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "anagram";
            string secondWord = "nagaram";
            bool result = Result.IsAnagram(firstWord, secondWord);
            Console.WriteLine(result);
        }
    }

    internal class Result
    {
        internal static bool IsAnagram(string firstWord, string secondWord)
        {
            if (firstWord.Length != secondWord.Length) return false;
            var dict = new Dictionary<char, int>();
            foreach (var item in firstWord)
            {
                dict[item] = dict.ContainsKey(item) ? (dict[item] + 1) : 1;
            }
            foreach (var item in secondWord)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item] -= 1;
                    if (dict[item] < 0) return false;
                }
                else
                {
                    return false;
                }
            }
            return dict.All(d => d.Value == 0);
        }
    }
}