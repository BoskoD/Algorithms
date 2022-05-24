//https://www.hackerrank.com/challenges/bon-appetit/problem?isFullScreen=true
using System;

namespace BillDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bill = new int[] { 3, 10, 2, 9 };
            int declinedFoodIndex = 1;
            int billChargedToAnna = 7;
            // condition: billChargedToAnna == ok ? "Bon Appetit" : difference

            Console.WriteLine(Result.BonAppetit(bill, declinedFoodIndex, billChargedToAnna));
        }
    }

    internal class Result
    {
        internal static string BonAppetit(int[] bill, int declinedFoodIndex, int billChargedToAnna)
        {
            var sharedFoodItems = 0;
            for (int i = 0; i < bill.Length; i++)
            {
                if (i != declinedFoodIndex)
                {
                    sharedFoodItems += bill[i];
                }
            }

            var annaShare = sharedFoodItems / 2;

            return billChargedToAnna == annaShare ? 
                "Bon Appetit" : (billChargedToAnna - annaShare).ToString();
        }
    }
}