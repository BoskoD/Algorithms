//https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/578/
using System;
using System.Collections.Generic;

namespace ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            bool result = Result.ContainsDuplicate(array);
            Console.WriteLine(result);
        }
    }

    internal class Result
    {
        internal static bool ContainsDuplicate(int[] array)
        {
            HashSet<int> checkSet = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!checkSet.Add(array[i])) 
                {
                    return true;
                }
            }
            return false;
        }
    }
}