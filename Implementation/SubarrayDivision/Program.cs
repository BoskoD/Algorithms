//https://www.hackerrank.com/challenges/the-birthday-bar/problem?isFullScreen=true
using System;
using System.Collections.Generic;
using System.Linq;

namespace SubarrayDivision
{
    internal class Program
    {
        //The length of the segment matches Ron's birth month, and,
        //The sum of the integers on the squares is equal to his birth day.

        static void Main(string[] args)
        {
            List<int> segmetns = new List<int> { 1, 2, 1, 3, 2 };
            int day = 3;
            int month = 2;
            int howManyWaysWeCanDivideChocolate = Result.Birthday(segmetns, day, month);

            Console.WriteLine($"Can divide chocolate in {howManyWaysWeCanDivideChocolate} ways.");
        }
    }

    internal class Result
    {
        public static int Birthday(List<int> segments, int day, int month)
        {
            int ways = 0;
            for (int i = 0; i < segments.Count - (month - 1); i++) 
            {
                if (segments.Skip(i).Take(month).Sum() == day)
                {
                    ways++;
                }
            }
            return ways;
        }
    }
}