using System;

namespace ImplementStrStr
{
    public class Program
    {
        static void Main(string[] args)
        {
            string haystack = "hello";
            string needle = "ll";
            var indexOfNeedle = Result.StrStr(haystack, needle);
            Console.WriteLine($"Needle found at index {indexOfNeedle}");
        }
    }

    public static class Result
    {
        public static int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                return haystack.IndexOf(needle);
            }
            return -1;
        }
    }
}