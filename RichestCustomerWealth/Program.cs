namespace RichestCustomerWealth
{
    internal class Program // Array, Matrix
    {
        static void Main(string[] args)
        {
            int[][] accounts = [[1, 5], [8, 3], [3, 5]];
            int richestAccount = RichestCustomerWealthLINQ(accounts);
            Console.WriteLine(richestAccount);
        }

        public static int RichestCustomerWealth(int[][] accounts)
        {
            int richestAccount = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int maxValue = 0;
                foreach (int val in accounts[i])
                {
                    maxValue += val;
                }
                richestAccount = Math.Max(richestAccount, maxValue);
            }
            return richestAccount;
        }

        public static int RichestCustomerWealthLINQ(int[][] accounts)
        {
            return accounts.Max(account => account.Sum());
        }
    }
}
