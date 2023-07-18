namespace TwoSum
{
    internal class Program // Array, HashTable
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 2, 3, 4, 7, 10 };
            var target = 11;
            var result = CalculateTwoSum(nums, target);
            Console.WriteLine($"Index 0: {result[0]}");
            Console.WriteLine($"Index 1: {result[1]}");
        }

        public static int[] CalculateTwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
            {
                return new int[2];
            }

            Dictionary<int, int> previousMap = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (previousMap.ContainsKey(target - nums[i]))
                {
                    return new int[] { previousMap[target - nums[i]], i };
                }
                else if (!previousMap.ContainsKey(target - nums[i]))
                {
                    previousMap.Add(nums[i], i);
                }
            }
            return new int[2];
        }
    }
}