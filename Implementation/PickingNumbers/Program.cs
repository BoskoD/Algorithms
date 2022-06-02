//https://www.hackerrank.com/challenges/picking-numbers/problem?isFullScreen=true
using System;
using System.Collections.Generic;

namespace PickingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>{ 1, 1, 2, 2, 4, 4, 5, 5, 5 };
            int longestSubArray = Result.PickingNumbers(list);
            Console.WriteLine($"The maximum length subarray has {longestSubArray} elements.");
        }
    }

    internal class Result
    {
        internal static int PickingNumbers(List<int> list)
        {
            int[] array = list.ToArray();
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int temp = 0;
                Array.Sort(array);
                for (int j = i; j < array.Length; j++)
                {
                    if (Math.Abs(array[i] - array[j]) <= 1)
                    {
                        temp++;
                    }
                    else 
                    {
                        break;
                    }
                }
                if (temp > max) 
                {
                    max = temp;
                }
            }
            return max;
        }
    }
}