//https://www.hackerrank.com/challenges/strange-advertising/problem?isFullScreen=true
using System;

namespace ViralAdvertising
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int totalLikes = Result.ViralAdvertising(numberOfDays);
            Console.WriteLine($"In {numberOfDays} days {totalLikes} people will like the ad!");
        }
    }

    internal class Result
    {
        internal static int ViralAdvertising(int numberOfDays)
        {
            var totalLikes = 0D;
            var shareCount = 5.0;

            for (int i = 0; i < numberOfDays; i++)
            {
                totalLikes += Math.Floor(shareCount / 2);
                shareCount = Math.Floor(shareCount / 2) * 3;
            }
            return (int)totalLikes;
        }
    }
}