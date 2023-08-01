namespace ContainerWithMostWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int maxArea = MaxArea(heights);
            Console.WriteLine($"Max area is {maxArea}.");
        }

        public static int MaxArea(int[] heights)
        {
            int result = 0;
            int area = 0;
            int left = 0;
            int right = heights.Length - 1;

            while (left < right)
            {
                area = Math.Min(heights[left], heights[right]) * (right - left);
                result = Math.Max(result, area);

                if (heights[left] < heights[right]) left++;
                else { right--; }
            }
            return result;
        }
    }
}