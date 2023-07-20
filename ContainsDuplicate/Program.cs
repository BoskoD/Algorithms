namespace ContainsDuplicate
{
    internal class Program // Array, HashTable, Sorting
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 2, 43, 45, 6 };
            var containsDuplicate = DetectectDuplicate(nums);
            Console.WriteLine($"Provided array contains duplicate? {containsDuplicate}");
        }

        public static bool DetectectDuplicate(int[] nums)
        {
            if (nums is not null && nums.Length < 2) { return false; }

            HashSet<int> set = new();
            foreach (var num in nums)
            {
                if (set.Contains(num)) { return true; }
                if (!set.Contains(num)) { set.Add(num); }
            }
            return false;
        }
    }
}