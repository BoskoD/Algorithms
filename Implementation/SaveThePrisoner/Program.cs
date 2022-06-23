//https://www.hackerrank.com/challenges/save-the-prisoner/problem?isFullScreen=true
using System;

namespace SaveThePrisoner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPrisoners = 4;
            int countOfCandy = 6;
            int prisonerId = 2; // 1:1 mapping with sitting chair

            int result = Result.SaveThePrisoner(countOfPrisoners, countOfCandy, prisonerId);
            Console.WriteLine($"The prisoner that should be warned sits on chair number: {result}");
        }
    }

    internal class Result
    {
        internal static int SaveThePrisoner(int countOfPrisoners, int countOfCandy, int prisonerId)
        {
            var remainingPrisonersBeforeEnd = countOfPrisoners - prisonerId + 1;

            if (countOfCandy > remainingPrisonersBeforeEnd) 
            {
                prisonerId = 1;
                countOfCandy -= remainingPrisonersBeforeEnd;
                countOfCandy %= countOfPrisoners;
            }

            if (countOfCandy == 0)
            {
                prisonerId = countOfPrisoners;
            }
            else 
            {
                prisonerId += countOfCandy - 1;
            }
            return prisonerId;
        }
    }
}