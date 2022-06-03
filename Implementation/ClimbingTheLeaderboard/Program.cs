//https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem?isFullScreen=true
//https://en.wikipedia.org/wiki/Ranking#Dense_ranking_.28.221223.22_ranking.29
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClimbingTheLeaderboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

            int playerCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

            List<int> result = Result.ClimbingLeaderboard(ranked, player);

            Console.WriteLine(String.Join("\n", result));
        }
    }

    internal class Result
    {
        internal static List<int> ClimbingLeaderboard(List<int> rank, List<int> newPlayersScore)
        {
            List<int> result = new List<int>();

            var cleanRanks = rank.ToHashSet().ToArray();
            int i = cleanRanks.Length - 1;

            for (int j = 0; j < newPlayersScore.Count; j++)
            {
                bool rankFound = false;
                while (!rankFound && i >= 0) 
                {
                    if (newPlayersScore[j] < cleanRanks[i])
                    {
                        result.Add(i + 2);
                        rankFound = true;
                    }
                    else if (newPlayersScore[j] == cleanRanks[i])
                    {
                        result.Add(i + 1);
                        rankFound = true;
                    }
                    else
                    {
                        i--;
                    }
                }
                if (!rankFound)
                {
                    result.Add(1);
                }
            }
            return result;
        }
    }
}