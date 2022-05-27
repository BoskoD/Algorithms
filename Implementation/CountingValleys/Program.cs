//https://www.hackerrank.com/challenges/counting-valleys/problem?isFullScreen=true
using System;

namespace CountingValleys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = Convert.ToInt32(Console.ReadLine());
            string path = Console.ReadLine();
            int valleysCount = Result.CountValleys(steps, path);
            Console.WriteLine($"Count of valleys: {valleysCount}.");
        }
    }

    internal class Result
    {
        internal static int CountValleys(int steps, string path)
        {
            int altitude = 0;
            int valleys = 0;

            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    if (altitude == -1)
                    {
                        valleys++;
                    }
                    altitude++;
                }
                if (path[i] == 'D')
                {
                    altitude--;
                }
            }
            return valleys;
        }
    }
}