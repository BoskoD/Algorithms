namespace TwoSum_II_InputArrayIsSorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 13;
            var result = TwoSumIISortedInputArray(nums, target);
            Console.WriteLine($"{result[0]}, {result[1]}");
        }

        public static int[] TwoSumIISortedInputArray(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[left] + nums[right];

                if (sum > target) right--;
                else if (sum < target) left++;
                else 
                { 
                    return new int[] { left + 1, right + 1 }; 
                }
            }
            return new int[2];
        }
    }
}