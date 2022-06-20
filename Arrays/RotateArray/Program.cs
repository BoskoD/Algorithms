//https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
using System;

namespace RotateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            var rotate = Result.RotateArray(array, k);
            for (int i = 0; i < rotate.Length; i++)
            {
                Console.Write(rotate[i]);
            }
        }
    }

    internal class Result
    {
        internal static int[] RotateArray(int[] array, int k)
        {
            int length = array.Length;
            int[] temp = new int[length];

            for (int i = 0; i < length; i++)
            {
                temp[(i + k) % length] = array[i];
            }
            for (int i = 0; i < length; i++)
            {
                array[i] = temp[i];
            }
            return array;
        }
    }
}