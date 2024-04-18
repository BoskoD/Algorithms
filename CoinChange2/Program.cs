namespace CoinChange2
{
    internal class Program // Arrays, Dynamic Programming
    {
        static void Main(string[] args)
        {
            int amount = 5;
            int[] coins = [1, 2, 5];
            int result = CoinChangeCombinations(coins, amount);
            Console.WriteLine(result);
        }

        public static int CoinChangeCombinations(int[] coins, int amount)
        {
            int[] combinations = new int[amount + 1];
            combinations[0] = 1; // base case

            foreach (int coin in coins)
            {
                for (int i = coin; i <= amount; i++)
                {
                    combinations[i] += combinations[i - coin];
                }
            }
            return combinations[amount];
        }
    }
}
