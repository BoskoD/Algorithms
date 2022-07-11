//https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/567/
using System;

namespace MoveZeros
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12 };
            Result.MoveZeros(nums);
        }
    }

    public class Result
    {
        public static void MoveZeros(int[] nums)
        {
            if (nums == null || nums.Length <= 1) 
            {
                return;
            }
            int current = 0;
            int next = 1;

            while (next <= nums.Length - 1) 
            {
                if (nums[current] == 0)
                {
                    if (nums[next] == 0)
                    {
                        next++;
                        continue;
                    }
                    else
                    {
                        nums[current] = nums[next];
                        nums[next] = 0;
                    }
                }
                current++;
                next++;
            }
            Print(nums);
        }

        public static void Print(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}