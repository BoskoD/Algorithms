//https://www.hackerrank.com/challenges/angry-professor/problem?isFullScreen=true
using System;
using System.Collections.Generic;

namespace AngryProfessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arrivalTimes = new List<int> { -1, -3, 4, 2 };
            int thresholdForTheClassToBeHeld = 3;

            string willTheClassBeCancelled = Result.AngryProf(thresholdForTheClassToBeHeld, arrivalTimes);
            Console.WriteLine(willTheClassBeCancelled);
        }
    }

    internal class Result
    {
        internal static string AngryProf(int k, List<int> arrivalTimes)
        {
            int studentsArrivedOnTime = 0;

            foreach (int std in arrivalTimes)
            {
                if (std <= 0) studentsArrivedOnTime++;
            }
            return studentsArrivedOnTime >= k ? "NO" : "YES";
        }
    }
}