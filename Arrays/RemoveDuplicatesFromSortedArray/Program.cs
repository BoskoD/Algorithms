//https://leetcode.com/explore/featured/card/top-interview-questions-easy/92/array/727/
using System;

namespace RemoveDuplicatesFromSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int length = Result.RemoveDuplicates(numbers);
            Console.WriteLine($"Length of updated array: {length}");
            for (int i = 0; i < length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }

    internal class Result
    {
        internal static int RemoveDuplicates(int[] numbers)
        {
            if (numbers.Length == 0) 
            {
                return 0;
            }

            int previous = numbers[0];
            int currentIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (previous != numbers[i]) 
                {
                    currentIndex++;
                    numbers[currentIndex] = numbers[i];
                    previous = numbers[i];
                }
            }
            return currentIndex + 1;
        }
    }
}