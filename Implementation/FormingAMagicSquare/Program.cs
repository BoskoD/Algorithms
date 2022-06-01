// https://www.hackerrank.com/challenges/magic-square-forming/problem?isFullScreen=true
// https://en.wikipedia.org/wiki/Magic_square
using System;
using System.Collections.Generic;
using System.Linq;

namespace FormingAMagicSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 9 2
            //3 5 7
            //8 1 5

            //Sample output: 1

            //If we change the bottom right value, , from 5 to 6 at a cost of 1, square becomes a magic square at the minimum possible cost.

            List<List<int>> s = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList()
                     .Select(sTemp => Convert.ToInt32(sTemp)).ToList());
            }
            int minCostToAchieveMagicSquare = Result.FormingMagicSquareCost(s);
            Console.WriteLine($"Minimum cost to achieve magic square is: {minCostToAchieveMagicSquare}.");
        }
    }

    internal class Result
    {
        internal static int FormingMagicSquareCost(List<List<int>> square)
        {
            List<List<List<int>>> collection = new List<List<List<int>>>()
            {
                new List<List<int>>() {new List<int>() {8, 1, 6}, new List<int>() {3, 5, 7}, new List<int>() {4, 9, 2}},
                new List<List<int>>() {new List<int>() {6, 1, 8}, new List<int>() {7, 5, 3}, new List<int>() {2, 9, 4}},
                new List<List<int>>() {new List<int>() {4, 9, 2}, new List<int>() {3, 5, 7}, new List<int>() {8, 1, 6}},
                new List<List<int>>() {new List<int>() {2, 9, 4}, new List<int>() {7, 5, 3}, new List<int>() {6, 1, 8}},
                new List<List<int>>() {new List<int>() {8, 3, 4}, new List<int>() {1, 5, 9}, new List<int>() {6, 7, 2}},
                new List<List<int>>() {new List<int>() {4, 3, 8}, new List<int>() {9, 5, 1}, new List<int>() {2, 7, 6}},
                new List<List<int>>() {new List<int>() {6, 7, 2}, new List<int>() {1, 5, 9}, new List<int>() {8, 3, 4}},
                new List<List<int>>() {new List<int>() {2, 7, 6}, new List<int>() {9, 5, 1}, new List<int>() {4, 3, 8}},
            };


            int min = Int32.MaxValue;
            foreach (var item in collection)
            {
                int temp = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        temp += Math.Abs(square[i][j] - item[i][j]);
                    }
                }
                min = Math.Min(min, temp);
            }
            return min;
        }
    }
}