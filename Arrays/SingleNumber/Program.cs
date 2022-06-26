//https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/549/
using System;
using System.Linq;

namespace SingleNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 1, 2, 1, 2 };
            var result = Result.SingleNumber(nums);
            Console.WriteLine(result);
        }
    }

    internal class Result
    {
        internal static object SingleNumber(int[] nums)
        {
            return nums.Aggregate(0, (current, i) => current ^ i);
        }
    }
}