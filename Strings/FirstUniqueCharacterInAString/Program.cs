//https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/881/
using System;
using System.Linq;

namespace FirstUniqueCharacterInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "parallel"; // first unique char in a string should be 0
            var result = Result.FirstUniqueChar(word);
            Console.WriteLine(result);
        }
    }

    internal class Result
    {
        internal static int FirstUniqueChar(string word)
        {
            foreach (var item in word.Distinct())
            {
                if (word.Count(x => x == item) == 1) 
                {
                    return word.IndexOf(item);
                }
            }
            return -1;
        }
    }
}