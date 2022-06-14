//https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem?isFullScreen=true
using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimumAbsoluteDifferenceInAnArray
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var arr_temp = Console.ReadLine().Split(' ');
            var inputNumbers = Array.ConvertAll(arr_temp, int.Parse);

            Result.MinAbsDifferenceInArr(inputNumbers);
        }
    }

    internal class Result
    {
        internal static void MinAbsDifferenceInArr(int[] inputNumbers)
        {
            inputNumbers = QuickSort(inputNumbers);
            var minimumDiff = Math.Abs(inputNumbers[0] - inputNumbers[1]);
            for (var i = 1; i < inputNumbers.Length - 1; i++)
            {
                minimumDiff = Math.Min(Math.Abs(inputNumbers[i] - inputNumbers[i + 1]), minimumDiff);
            }
            Console.WriteLine(minimumDiff);
        }

        static int[] QuickSort(int[] arr)
        {
            var pivot = arr[0];
            var smallerItems = new List<int>();
            var equalItems = new List<int>();
            var biggerItems = new List<int>();
            var outputArr = new int[arr.Length];

            equalItems.Add(arr[0]);

            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] < pivot) smallerItems.Add(arr[i]);
                else if (arr[i] > pivot)
                {
                    biggerItems.Add(arr[i]);
                }
                else
                {
                    equalItems.Add(arr[i]);
                }
            }

            if (smallerItems.Count > 1)
                smallerItems = QuickSort(smallerItems.ToArray()).ToList();

            if (biggerItems.Count > 1)
                biggerItems = QuickSort(biggerItems.ToArray()).ToList();

            var j = 0;

            foreach (var item in smallerItems)
                outputArr[j++] = item;

            foreach (var item in equalItems)
                outputArr[j++] = item;

            foreach (var item in biggerItems)
                outputArr[j++] = item;

            return outputArr;
        }
    }
}