using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

            int result = Result.JumpingOnClouds(c);

            Console.WriteLine(result);
        }
    }

    class Result
    {
        public static int JumpingOnClouds(List<int> c)
        {
            int result = 0, path = c.Count - 1;
            for (int i = 0; i < path; i += 2, result++)
            {
                if (c[i] == 1)
                {
                    i--;
                }
            }
            return result;
        }
    }
}

// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup