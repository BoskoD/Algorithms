//https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/674/
using System;
using System.Linq;

namespace IntersectionOfTwoArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 2, 1 };
            int[] arr2 = new int[] { 2, 2, 3 };
            var result = Result.FindIntersection(arr1, arr2);
            Result.Print(result);
        }
    }

    public class Result
    {
        public static int[] FindIntersection(int[] arr1, int[] arr2)
        {
            var map1 = arr1.GroupBy(n => n).ToDictionary(g => g.Key, g => g.Count());
            return arr2.Where(n => map1.ContainsKey(n) && map1[n]-- > 0).ToArray();
        }

        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}