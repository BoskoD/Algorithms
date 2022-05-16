using System;
using System.IO;

namespace DiagonalDifference
{
    class Result
    {
        public static int diagonalDifference(int[][] arr)
        {
            int sumLr = 0;
            int sumRl = 0;
            int length = arr[0].Length;

            for (int i = 0; i < length; i++)
            {
                sumLr += arr[i][0 + i];
                sumRl += arr[i][length - i - 1];
            }
            return Math.Abs(sumLr - sumRl);
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = Result.diagonalDifference(arr);

            Console.WriteLine(result);
        }
    }
}