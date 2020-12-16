using System;
using System.Collections.Generic;
using System.Linq;

namespace BreakingTheRecords
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOfGames = int.Parse(Console.ReadLine());
            List<int> games = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] scores = new int[2];
            int best = games[0];
            int worst = games[0];

            CountScores(best, worst, games, scores);

            Console.WriteLine(string.Join(" ", scores));
        }

        private static void CountScores(int best, int worst, List<int> games, int[] scores)
        {
            List<int> highest = new List<int>();
            for (int i = 1; i < games.Count; i++)
            {
                if (games[i] > best)
                {
                    best = games[i];
                    highest.Add(best);
                    ++scores[0];
                }
                else if (games[i] < worst)
                {
                    worst = games[i];
                    ++scores[1];
                }
            }
        }
    }
}