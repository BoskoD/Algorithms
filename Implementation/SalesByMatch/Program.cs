using System;
using System.Collections.Generic;

namespace SalesByMatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] socks = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int size = socks.Length;
            int pairs = Result.SockMerchant(size, socks);
            Console.WriteLine(pairs);
        }
    }

    public class Result
    {
        public static int SockMerchant(int size, int[] socks)
        {
            var colors = new HashSet<int>();
            int pairs = 0;

            for (int i = 0; i < size; i++)
            {
                if (!colors.Contains(socks[i]))
                {
                    colors.Add(socks[i]);
                }
                else 
                {
                    pairs++;
                    colors.Remove(socks[i]);
                }
            }
            return pairs;
        }
    }
}