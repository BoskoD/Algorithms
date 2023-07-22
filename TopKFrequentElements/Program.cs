namespace TopKFrequentElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            int[] result1 = TopKFrequentHeap(nums, k);
            Console.WriteLine("Top K Frequent Elements:");
            Console.WriteLine("[" + string.Join(", ", result1) + "]");
        }

        public static int[] TopKFrequentHeap(int[] nums, int k)
        {
            var arr = new int[k];
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else { dict.Add(nums[i], 1); }
            }

            var pq = new PriorityQueue<int, int>();
            foreach (var key in dict.Keys)
            {
                pq.Enqueue(key, dict[key]);
                if (pq.Count > k) { pq.Dequeue(); }
            }

            int i2 = k;
            while (pq.Count > 0)
            {
                arr[--i2] = pq.Dequeue();
            }

            return arr;
        }

        //public static int[] TopKFrequentLINQ(int[] nums, int k)
        //{
        //    return nums.GroupBy(num => num)
        //    .OrderByDescending(num => num.Count())
        //    .Take(k)
        //    .Select(c => c.Key)
        //    .ToArray();
        //}
    }
}