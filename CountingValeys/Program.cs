using System;
using System.IO;

namespace CountingValeys
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = Result.CountingValleys(steps, path);

            Console.WriteLine(result);
        }
    }

    class Result
    {
        public static int CountingValleys(int steps, string path)
        {
            int seaLevel = 0, valey = 0;
            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    seaLevel += 1;
                }
                else {
                    seaLevel -= 1;
                }

                if (path[i] == 'U' && seaLevel == 0)
                {
                    valey += 1;
                }
            }
            return valey;
        }
    }
}

// https://www.hackerrank.com/challenges/counting-valleys/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
