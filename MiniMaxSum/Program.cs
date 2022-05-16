using System;
using System.Linq;

namespace MiniMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Result.MiniMaxSum(arr);
        }
    }

    class Result
    {
        public static void MiniMaxSum(int[] arr)
        {
            Array.Sort(arr);
            long min = arr.Take(4).Sum(item => (long)item);
            long max = arr.Skip(1).Sum(item => (long)item);

            Console.WriteLine($"{min} {max}");
        }
    }
}