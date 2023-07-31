namespace LongestConsecutiveSequence
{
    internal class Program // Array, HashTable
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
            int sequence = LongestSequence(nums);
            Console.WriteLine($"Longest consecutive sequence is {sequence}");
        }

        public static int LongestSequence(int[] nums)
        {
            if (nums.Length < 2) return nums.Length;

            HashSet<int> set = new(nums);
            int longest = 0;

            foreach (var n in set)
            {
                if (!set.Contains(n - 1))
                {
                    int length = 0;
                    while (set.Contains(n + length))
                    {
                        length++;
                        longest = Math.Max(longest, length);
                    }
                }
            }
            return longest;
        }
    }
}