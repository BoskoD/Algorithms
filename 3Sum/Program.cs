namespace _3Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            var result = Calculate3Sum(nums);
            foreach (var item in result)
            {
                Console.WriteLine(string.Join(",", item));
            }
        }

        public static IList<IList<int>> Calculate3Sum(int[] nums)
        {
            int left, right;
            var result = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                left = i + 1;
                right = nums.Length - 1;
                while (left < right)
                {
                    if (nums[i] + nums[left] + nums[right] > 0) right--;
                    else if (nums[i] + nums[left] + nums[right] < 0) left++;
                    else
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        left++;
                        while (nums[left] == nums[left - 1] && left < right)
                            left++;
                    }
                }
            }
            return result;
        }
    }
}