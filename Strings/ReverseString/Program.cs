//https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/879/
using System;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] word = new char[] { 'h', 'e', 'l', 'l', 'o' };
            Result.ReverseString(word);
            String.Join(',', word);
            Console.WriteLine(word);
            
        }
    }

    internal class Result
    {
        internal static void ReverseString(char[] word)
        {
            int length = word.Length;
            for (int i = 0; i < length / 2; i++) 
            {
                var temp = word[i];
                word[i] = word[length - i - 1];
                word[length - i - 1] = temp;
                // (word[length - i - 1], word[i]) = (word[i], word[length - i - 1]);
                // we can use tupple to swap values as well
            }
        }
    }
}