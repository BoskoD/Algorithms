using System;
using System.Collections.Generic;
using System.Linq;

namespace BetweenTwoSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //No need to capture number of elments in set A and B as I use foreach loop to iterate them.
            Console.ReadLine();
            var a_temp = Console.ReadLine().Split(' ');
            var setA = Array.ConvertAll(a_temp, Int32.Parse);

            var b_temp = Console.ReadLine().Split(' ');
            var setB = Array.ConvertAll(b_temp, Int32.Parse);

            int total = Result.GetTotalX(setA, setB);
            Console.WriteLine(total);
        }
    }

    internal class Result
    {
        internal static int GetTotalX(int[] setA, int[] setB)
        {
            var totalX = 0;
            var maxA = setA.Max();
            var minB = setB.Min();
            var counter = 1;

            var multipleOfMaxA = maxA;

            while (multipleOfMaxA <= minB) 
            {
                var factorOfAll = true;

                foreach (var item in setA)
                {
                    if (multipleOfMaxA % item != 0) 
                    {
                        factorOfAll = false;
                        break;
                    }
                }

                if (factorOfAll)
                {
                    foreach (var item in setB)
                    {
                        if (item % multipleOfMaxA != 0) 
                        {
                            factorOfAll = false;
                            break;
                        }
                    }
                }

                if (factorOfAll)
                {
                    totalX++;
                }
                counter++;
                //Here counter is the x factor which contributes to O(x(n+m)) complexity.
                multipleOfMaxA = maxA * counter; 
            }
            return totalX;
        }
    }
}