using System;

namespace StrongPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            string password = Console.ReadLine();

            int answer = Result.MinimumNumber(n, password);

            Console.WriteLine(answer);

        }
    }

    class Result
    {
        internal static int MinimumNumber(int n, string password)
        {
            var numbers = "0123456789".ToCharArray();
            var lower_case = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var special_characters = "!@#$%^&*()-+".ToCharArray();

            int requirements = 0;

            if (password.IndexOfAny(numbers) == -1)
            {
                requirements++;
            }
            if (password.IndexOfAny(lower_case) == -1)
            {
                requirements++;
            }
            if (password.IndexOfAny(upper_case) == -1)
            {
                requirements++;
            }
            if (password.IndexOfAny(special_characters) == -1)
            {
                requirements++;
            }
            return requirements > 6 - n ? requirements : 6 - n;
        }
    }
}