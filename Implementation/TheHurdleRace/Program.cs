//https://www.hackerrank.com/challenges/the-hurdle-race/problem?isFullScreen=true
using System;
using System.Collections.Generic;
using System.Linq;

namespace TheHurdleRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> height = new List<int> { 1, 6, 3, 5, 2 };
            int k = 4;
            int neededDoses = Result.HurdleRace(height, k);

            Console.WriteLine($"Need to take {neededDoses} doses to finish the race!");
        }
    }

    internal class Result
    {
        internal static int HurdleRace(List<int> height, int k)
        {
            int max = height[0];
            var arr = height.ToArray();

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return Math.Max(0, max - k);
        }

        internal static int HurdleRaceLinq(List<int> height, int k)
        {
            return Math.Max(0, height.Max() - k);
        }
    }
}