//https://www.hackerrank.com/challenges/utopian-tree/problem?isFullScreen=true
using System;

namespace UtopianTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int iteration = 0; iteration < t; iteration++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int result = Result.UtopianTree(n);

                Console.WriteLine(result);
            }
        }
    }

    internal class Result
    {
        internal static int UtopianTree(int n)
        {
            int height = 1;

            for (int cycles = 1; cycles <= n; cycles++)
            {
                if (cycles % 2 == 1)
                {
                    height *= 2;
                }
                else
                {
                    height++;
                }
            }
            return height;
        }
    }
}