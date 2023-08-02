namespace TrappingRainWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int trappedWawterUnits = TrapWater(height);
            Console.WriteLine($"We can trap {trappedWawterUnits} units of water.");
        }

        public static int TrapWater(int[] height)
        {
            if (height == null || height.Length == 0) return 0;

            int left = 0;
            int right = height.Length - 1;

            int maxLeft = height[left];
            int maxRight = height[right];

            int result = 0;

            while(left < right)
            {
                if (height[left] < height[right])
                {
                    left++;
                    maxLeft = Math.Max(maxLeft, height[left]);
                    result += maxLeft - height[left];
                }
                else
                {
                    maxRight = Math.Max(maxRight, height[right]);
                    result += maxRight - height[right];
                    right--;
                }
            }
            return result;
        }
    }
}