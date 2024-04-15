namespace ConcatenationOfArray
{
    internal class Program // Array
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 2, 1];
            int[] result = GetConcatenation(nums);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public static int[] GetConcatenation(int[]nums)
        {
            int[] result = new int[nums.Length * 2];

            for(int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
                result[nums.Length + i] = nums[i];
            }
            return result;
        }
    }
}
