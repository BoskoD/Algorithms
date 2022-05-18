using System;
using System.Collections.Generic;
using System.Linq;

namespace AppleAndOrange
{
    //Sample input
    //7 11 // house location in between
    //5 15 // 5-location of apple tree 15-loation of orange tree
    //3 2 // 3-apples fall and 2-oranges fall
    //-2 2 1 points where apples fall
    //5 -6 points where oranges fall
    //Output
    //1 1 fall on Sam's house
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int startPointOfSamHouse = Convert.ToInt32(firstMultipleInput[0]);
            int endPointOfSamHouse = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int appleTreeLocation = Convert.ToInt32(secondMultipleInput[0]);
            int orangeTreeLocation = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);
            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> applesCount = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();
            List<int> orangesCount = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            Result.CountApplesAndOranges(startPointOfSamHouse, endPointOfSamHouse, appleTreeLocation, orangeTreeLocation, applesCount, orangesCount);
        }
    }

    internal class Result
    {
        internal static void CountApplesAndOranges(int startPointOfSamHouse, int endPointOfSamHouse, 
                                                   int appleTreeLocation, int orangeTreeLocation, 
                                                   List<int> apples, List<int> oranges)
        {
            int apple = 0;
            int orange = 0;
            foreach (var app in apples)
            {
                if (app + appleTreeLocation >= startPointOfSamHouse && app + appleTreeLocation <= endPointOfSamHouse)
                {
                    apple++;
                }
            }
            foreach (var org in oranges)
            {
                if (org + orangeTreeLocation >= startPointOfSamHouse && org + endPointOfSamHouse <= endPointOfSamHouse)
                {
                    orange++;
                }
            }
            Console.WriteLine($"" +
                $"Apples falling on Sam's house: {apple}\n" +
                $"Oranges falling on Sam's house: {orange}");
        }
    }
}