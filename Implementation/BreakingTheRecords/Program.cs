//https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem?isFullScreen=true&h_r=next-challenge&h_v=zen
using System;

namespace BreakingTheRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1, };
            int games = scores.Length;

            var result = Result.BreakingRecords(scores);
            Console.WriteLine($"Games:{games}\nMax records:{result[0]}\nMin records:{result[1]}");
        }
    }

    internal class Result
    {
        internal static int[] BreakingRecords(int[] scores)
        {
            int[] score = new int[2];

            int min = scores[0];
            int max = scores[0];

            int minScore = 0;
            int maxScore = 0;
            
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > max) 
                {
                    max = scores[i];
                    maxScore++;
                }
                if (scores[i]<min)
                {
                    min = scores[i];
                    minScore++;
                }
            }

            score[0] = maxScore;
            score[1] = minScore;

            return score;
        }
    }
}