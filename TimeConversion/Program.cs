using System;

namespace TimeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = Result.ConvertTimeToMilitary(s);
            Console.WriteLine(result);
        }
    }

    class Result 
    {
        public static string ConvertTimeToMilitary(string s)
        {
            bool succesfulConversion = DateTime.TryParse(s, out DateTime time);

            if (succesfulConversion)
            {
                return time.ToString("HH:mm:ss"); // upperCase HH for military time
            }

            return "Bad input";
        }
    }
}