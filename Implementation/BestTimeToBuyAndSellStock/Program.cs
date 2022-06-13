//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
using System;

namespace BestTimeToBuyAndSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            int maxProfitWeCanAchieve = Result.MaxProfit(prices);
            Console.WriteLine(maxProfitWeCanAchieve);
        }
    }

    internal class Result
    {
        internal static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = Int32.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                if (minPrice > prices[i])
                {
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }
            return maxProfit;
        }
    }
}