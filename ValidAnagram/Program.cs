namespace ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "anagram";
            var t = "nagaram";
            var isAnagram = IsAnagram(s, t);
            Console.WriteLine($"{s} is anagram of {t} -> {isAnagram}");
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s == t) { return true; }
            if (s.Length != t.Length) { return false; }

            Dictionary<char, int> sCounter = new();
            Dictionary<char, int> tCounter = new();

            for (int i = 0; i < s.Length; i++) // We counted all occurences here
            {
                sCounter[s[i]] = 1 + (sCounter.ContainsKey(s[i]) ? sCounter[s[i]] : 0);
                tCounter[t[i]] = 1 + (tCounter.ContainsKey(t[i]) ? tCounter[t[i]] : 0);
            }

            foreach (var c in sCounter.Keys) // Compare count for each character
            {
                var tCount = tCounter.ContainsKey(c) ? tCounter[c] : 0;
                if (sCounter[c] != tCount) return false;
            }
            return true;
        }
    }
}