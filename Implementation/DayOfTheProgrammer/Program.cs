//https://www.hackerrank.com/challenges/day-of-the-programmer/problem?isFullScreen=true
using System;

namespace DayOfTheProgrammer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var year = int.Parse(Console.ReadLine());
            string result = Result.DayOfTheProgrammer(year);
            Console.WriteLine(result);
        }
    }

    internal class Result
    {
        internal static string DayOfTheProgrammer(int year)
        {
            string programmerDay = ""; // 256th day
            if (year >= 1919)
            {
                programmerDay = GetProgrammerDayForGregorianCalendar(year);
            }
            else if (year <= 1917)
            {
                programmerDay = GetProgrammerDayForJulianCalendar(year);
            }
            else 
            {
                programmerDay = GetProgrammerDayForTransformationYear1918(year);
            }
            return programmerDay;
        }

        private static string GetProgrammerDayForTransformationYear1918(int year)
        {
            var daysTillAug = 31 + 15 + 31 + 30 + 31 + 30 + 31 + 31;
            var programmerDateInSept = 256 - daysTillAug;
            var formatedDate = programmerDateInSept + ".09." + year.ToString();
            return formatedDate;
        }

        private static string GetProgrammerDayForJulianCalendar(int year)
        {
            var daysTillAugInLeapYear = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31;
            var daysTillAugIn_NON_LeapYear = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
            var programmerDateInSept = IsJulianLeapYear(year) ? 256 - daysTillAugInLeapYear : 256 - daysTillAugIn_NON_LeapYear;
            var formatedDate = programmerDateInSept + ".09." + year.ToString();
            return formatedDate;
        }

        private static string GetProgrammerDayForGregorianCalendar(int year)
        {
            var daysTillAugInLeapYear = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31;
            var daysTillAugIn_NON_LeapYear = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
            var programmerDateInSeptember = IsGregorianLeapYear(year) ? 256 - daysTillAugInLeapYear : 256 - daysTillAugIn_NON_LeapYear;
            var dateWithFormat = programmerDateInSeptember + ".09." + year.ToString();
            return dateWithFormat;
        }

        private static bool IsGregorianLeapYear(int year)
        {
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0) 
            {
                return true;
            }
            return false;
        }

        private static bool IsJulianLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                return true;
            }
            return false;
        }
    }
}