using System;
using System.Collections.Generic;
using System.Linq;

namespace GradingStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.GradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));
        }
    }

    internal class Result
    {
        internal static List<int> GradingStudents(List<int> grades)
        {
            List<int> finalScores = new List<int>();

            foreach (int grade in grades)
            {
                if (grade % 5 < 3 || grade < 38)
                {
                    finalScores.Add(grade);
                }
                else
                {
                    finalScores.Add(grade + (5 - grade % 5));
                }
            }
            return finalScores;
        }

        ////using LINQ
        //internal static List<int> GradingStudents(List<int> grades)
        //{
        //    return grades.Select(grade =>
        //    {
        //        if (grade % 5 > 3 || grade < 38) 
        //        {
        //            return grade;
        //        }
        //        return grade + (5 - grade % 5);
        //    }).ToList();
        //}
    }
}