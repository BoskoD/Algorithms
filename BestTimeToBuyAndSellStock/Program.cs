namespace BestTimeToBuyAndSellStock
{
    internal class Program // Array, Dynamic Programming
    {
        static void Main(string[] args)
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int maxProfit = MaxProfit(prices);
            Console.WriteLine($"Max profit is {maxProfit}");
        }

        public static int MaxProfit(int[] prices)
        {
            int minValue = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                int currentValue = prices[i];
                minValue = Math.Min(minValue, currentValue);
                maxProfit = Math.Max(maxProfit, currentValue - minValue);
            }
            return maxProfit;
        }
    }
}