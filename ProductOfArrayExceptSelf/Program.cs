namespace ProductOfArrayExceptSelf
{
    internal class Program // Array, Prefix Sum
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4 };
            int[] result = CalculateProductOfArraysExceptSelf(nums);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]} ");
            }
        }

        public static int[] CalculateProductOfArraysExceptSelf(int[] nums)
        {
            int prefix = 1;
            int postfix = 1;
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            for (int i = nums.Length - 1; i > 0; i--) 
            {
                result[i] *= postfix;
                postfix *= nums[i];
            }
            return result; 
        }
    }
}