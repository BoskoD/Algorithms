using System;

namespace NumberLinesJump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int locationK1 = Convert.ToInt32(firstMultipleInput[0]);
            int moveRateK1 = Convert.ToInt32(firstMultipleInput[1]);
            int locationK2 = Convert.ToInt32(firstMultipleInput[2]);
            int moveRateK2 = Convert.ToInt32(firstMultipleInput[3]);

            string result = Result.Kangaroo(locationK1, moveRateK1, locationK2, moveRateK2);

            Console.WriteLine(result);
        }
    }

    internal class Result
    {
        internal static string Kangaroo(int locationK1, int moveRateK1, int locationK2, int moveRateK2)
        {
            string response = "NO";

            bool canCatchUp = (moveRateK2 < moveRateK1);

            if (canCatchUp)
            {
                //Check for round number. If not round number they cannot meet at any point.
                bool willIntersectOnLand = (locationK2 - locationK1) % (moveRateK1 - moveRateK2) == 0; 
                
                if (willIntersectOnLand)
                {
                    response = "YES";
                    
                }
            }
            return response;
        }
    }
}