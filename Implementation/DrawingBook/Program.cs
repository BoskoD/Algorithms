//https://www.hackerrank.com/challenges/drawing-book/problem?isFullScreen=true
using System;

namespace DrawingBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of pages?");
            int numberOfPages = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Which page are you looking for?");
            int pageToSearchFor = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.PageCount(numberOfPages, pageToSearchFor);
            Console.WriteLine($"Minimum number of pages you need to turn is: {result}");
        }
    }

    internal class Result
    {
        internal static int PageCount(int numberOfPages, int pageToSearchFor)
        {
            int[] sums = new int[2]; // check from fron and from the back
            sums[0] = pageToSearchFor / 2;
            sums[1] = numberOfPages / 2 - pageToSearchFor / 2;

            if (sums[0] < sums[1])
            {
                return sums[0];
            }
            return sums[1];
        }
    }
}