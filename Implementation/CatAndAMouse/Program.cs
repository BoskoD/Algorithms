//https://www.hackerrank.com/challenges/cats-and-a-mouse/problem?isFullScreen=true
using System;

namespace CatAndAMouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positionCatA = 2; // cat A position
            int positionCatB = 5; // cat B position
            int positionMouseC = 4; // mouse C position

            string result = Result.CatAndMouse(positionCatA, positionCatB, positionMouseC);
            Console.WriteLine(result);
        }
    }

    internal class Result
    {
        internal static string CatAndMouse(int positionCatA, int positionCatB, int positionMouseC)
        {
            int distanceCatA = Math.Abs(positionMouseC - positionCatA);
            int distanceCatB = Math.Abs(positionMouseC - positionCatB);

            if (distanceCatA == distanceCatB)
            {
                return "Mouse C";
            }
            else if (distanceCatA < distanceCatB)
            {
                return "Cat A";
            }
            else
            {
                return "Cat B";
            }
        }
    }
}