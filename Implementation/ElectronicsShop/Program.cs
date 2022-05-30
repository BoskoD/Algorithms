//https://www.hackerrank.com/challenges/electronics-shop/problem?isFullScreen=true
using System;
using System.Linq;

namespace ElectronicsShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 10, 2, 3 }; //10(budget) 2(keyboards) 3(USB)
            int[] keyboardPrices = new int[] { 3, 1 }; //3 1 - Keyboard prices
            int[] drivePrices = new int[] { 5, 2, 8 }; //5 2 8 - USB prices

            Console.WriteLine($"Budget: {input[0]}\nMost expensive pair that we can buy will cost: " +
                $"{Result.GetMoneySpent(input, keyboardPrices, drivePrices)}");
        }
    }

    internal class Result
    {
        internal static int GetMoneySpent(int[] input, int[] keyboardPrices, int[] drivePrices)
        {
            var budget = input[0];

            var sortedKeyBoardPrices = from keyboard in keyboardPrices
                                       orderby keyboard descending
                                       select keyboard;

            var sortedDrivePrices = from drive in drivePrices
                                    orderby drive ascending
                                    select drive;

            int maxSpendable = -1;

            foreach (var k in sortedKeyBoardPrices)
            {
                foreach (var d in sortedDrivePrices)
                {
                    if (k + d <= budget)
                    {
                        if (k + d > maxSpendable)
                        {
                            maxSpendable = k + d;
                        }
                    }
                    else 
                    {
                        break;
                    }
                }
            }
            return maxSpendable;
        }
    }
}