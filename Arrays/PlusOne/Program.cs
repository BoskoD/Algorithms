//https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/559/
using System;

namespace PlusOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[] { 2, 6, 9 };
            int[] incrementedDigits = Result.PlusOne(digits);
            Result.Print(incrementedDigits);
        }
    }

    public static class Result
    {
        public static int[] PlusOne(int[] digits)
        {
            var lastDigit = digits.Length - 1;
            while (lastDigit >= 0 && digits[lastDigit] == 9)
            {
                digits[lastDigit] = 0;
                lastDigit--;
            }
            if (lastDigit < 0)
            {
                Array.Resize(ref digits, digits.Length + 1);
                lastDigit = 0;
            }
            digits[lastDigit]++;
            return digits;
        }

        public static void Print(int[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                Console.WriteLine(digits[i]);
            }
        }
    }
}