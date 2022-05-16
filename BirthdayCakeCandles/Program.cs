using System;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUT: 4 candles, height 3,2,1,3
            int candlesCount = Convert.ToInt32(Console.ReadLine());
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int result = BdayCakeCandles(array);
            Console.WriteLine(result);
        }

        public static int BdayCakeCandles(int[] array)
        {
            int maxElement = array.Max();
            int counter = 0;

            foreach (int el in array)
            {
                if (maxElement == el) counter++;
            }
            return counter;
        }
    }
}