using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new[] { 1, 1, 0, -1, -1 };
            Result.PlusMinus(arr);
        }
    }

    class Result
    {
        public static void PlusMinus(int[] arr)
        {
            double positives = 0;
            double negatives = 0;
            double zeros = 0;
            double length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] > 0) positives++;
                else if (arr[i] < 0) negatives++;
                else zeros++;
            }

            Console.WriteLine($"Postivies:{positives/length:F6}");
            Console.WriteLine($"Negatives:{negatives / length:F6}");
            Console.WriteLine($"Zeros:{zeros / length:F6}");
        }
    }
}