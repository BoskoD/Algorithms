namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 9;
            int result = BinarySearchTarget(nums, target);
            Console.WriteLine($"{target} exists in nums and its index is {result}.");
        }

        public static int BinarySearchTarget(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + ((right - left) / 2);
                if (nums[mid] > target) right = mid - 1;
                else if (nums[mid] < target) left = mid + 1;
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}