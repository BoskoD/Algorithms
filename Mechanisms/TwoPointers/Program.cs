namespace TwoPointers
{
    internal class Program // Two-Pointers
    {
        static void Main(string[] _)
        {
            int[] numbers = [1, 3, 5, 6, 9, 11];
            int target = 7;

            int[] result = TwoSum(numbers, target);
            Console.WriteLine($"[{result[0]}, {result[1]}]");
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum == target) { return [numbers[left], numbers[right]]; }

                if (numbers[left] + numbers[right] > target)
                {
                    right--;
                }
                else { left++; }
            }
            return [0, 0];
        }
    }
}
