//https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem?isFullScreen=true
using System;

namespace BeautifulDaysAtTheMovies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingDay = 20;
            int endingDay = 23;
            int divisor = 6;
            int numOfBeautifulDays = Result.BeautifulDays(startingDay, endingDay, divisor);
            Console.WriteLine($"Number of beautiful days is {numOfBeautifulDays}");
        }
    }

    internal static class Result
    {
        public static int BeautifulDays(int i, int j, int k)
        {
            int counter = 0;
            for (int p = i; p <= j; p++)
            {
                int res = GetReversedDifference(p);
                if (res % k == 0) counter++;
            }
            return counter;
        }

        private static int GetReversedDifference(int value)
        {
            int temp = value;
            int reverse = 0;
            while (temp > 0)
            {
                reverse = reverse * 10 + temp % 10;
                temp /= 10;
            }
            return Math.Abs(value - reverse);
        }
    }
}