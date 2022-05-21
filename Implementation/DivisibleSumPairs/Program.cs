//https://www.hackerrank.com/challenges/divisible-sum-pairs/problem?isFullScreen=true&h_r=next-challenge&h_v=zen
using System;

namespace DivisibleSumPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] segment = new int[] { 1, 3, 2, 6, 1, 2 };
            int k = 3;
            int n = segment.Length;

            int result = Result.DivisibleSumPairsCount(segment, k, n);
            Console.WriteLine($"There are {result} pairs that can be divided by {k}");
        }
    }

    internal class Result
    {
        internal static int DivisibleSumPairsCount(int[] segment, int k, int n)
        {
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((segment[i] + segment[j]) % k == 0)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}