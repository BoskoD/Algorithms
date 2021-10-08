using System;

namespace RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.RepeatedString(s, n);

            Console.WriteLine(result);
        }
    }

    public class Result
    {
        internal static long RepeatedString(string s, long n)
        {
            long size = s.Length;
            long repeats = n / size;

            long left = n - (size * repeats);
            int extra = 0;

            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (s[i] == 'a')
                {
                    ++count;
                }
            }
            for (int i = 0; i < left; i++)
            {
                if (s[i] == 'a')
                {
                    ++extra;
                }
            }
            repeats = (repeats * count) + extra;
            return repeats;
        }
    }
}