using System;

namespace CamelCase
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int result = Result.CamelCase(s);

            Console.WriteLine(result);
        }
    }

    public class Result
    {
        public static int CamelCase(string s)
        {
            var chars = s.ToCharArray();
            int countOfWords = 0;

            foreach (var item in chars)
            {
                if (char.IsUpper(item))
                {
                    countOfWords++;
                }
            }
            countOfWords++;

            return countOfWords;
        }
    }
}