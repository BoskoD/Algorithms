using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesByMatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            int result = Result.sockMerchant(n, ar);

            Console.WriteLine(result);
        }
    }

    class Result
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            var colors = new HashSet<int>();
            int pairs = 0;

            for (int i = 0; i < n; i++)
            {
                if (!colors.Contains(ar[i]))
                {
                    colors.Add(ar[i]);
                }
                else
                {
                    pairs++;
                    colors.Remove(ar[i]);
                }
            }
            return pairs;
        }
    }
}

// https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup