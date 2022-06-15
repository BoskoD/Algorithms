//https://www.hackerrank.com/challenges/big-sorting/problem?isFullScreen=true
using System;

namespace BigSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] unsorted = new string[] { "120", "1", "20", "40" };

            Array.Sort(unsorted, (string a, string b) => 
            {
                if (a.Length == b.Length)
                {
                    return string.Compare(a, b, StringComparison.Ordinal);
                }
                return a.Length - b.Length;
            });
            Console.WriteLine(string.Join("\n", unsorted));
        }
    }
}