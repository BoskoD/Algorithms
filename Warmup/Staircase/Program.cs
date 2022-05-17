using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            Result.Staircase(4);
        }
    }

    class Result
    {
        public static void Staircase(int n) 
        {
            for (int y = n - 1; y >= 0; y--) // math vs cs
            {
                for (int x = 0; x < n; x++)
                {
                    if (x >= y)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}