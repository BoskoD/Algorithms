using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> birds = new List<int> { 1, 4, 4, 4, 5, 3 };
            int mostCommonlySeenBirdType = Result.MigratoryBirds(birds);
            Console.WriteLine($"Most commonly seen type is type: {mostCommonlySeenBirdType}");
        }
    }

    internal class Result
    {
        internal static int MigratoryBirds(List<int> birds)
        {
            int[] count = new int[birds.Max()];
            int max = 0;
            int counter = 0;

            for (int i = 0; i < birds.Count; i++)
            {
                count[birds[i] - 1]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (max < count[i])
                {
                    max = count[i];
                    counter = i;
                }
            }
            return counter + 1;
        }
    }
}