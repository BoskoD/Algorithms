namespace GroupAnagrams
{
    internal class Program // Array, Hash Table, String, Sorting
    {
        static void Main(string[] args)
        {
            var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var groups = GetAnagramsGroup(strs);

            Console.WriteLine("Grouped Anagrams:");
            foreach (IList<string> group in groups)
            {
                Console.WriteLine(string.Join(", ", group));
            }
        }

        public static IList<IList<string>> GetAnagramsGroup(string[] strs)
        {
            var groups = new Dictionary<string, IList<string>>();
            foreach (var str in strs) 
            {
                var hash = new char[26];
                foreach (var c in str) 
                {
                    hash[c - 'a']++;
                }

                var key = new string(hash);
                if (!groups.ContainsKey(key))
                {
                    groups[key] = new List<string>();
                }
                groups[key].Add(str);
            }
            return groups.Values.ToList();
        }
    }
}