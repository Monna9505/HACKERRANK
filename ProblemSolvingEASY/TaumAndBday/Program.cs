using System;
using System.Linq;

namespace TaumAndBday
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                long[] blackWhitePresentsCount = Console.ReadLine().Split()
                    .Select(long.Parse).ToArray();
                long[] bCwCZ = Console.ReadLine().Split()
                    .Select(long.Parse).ToArray();

                long blackPresents = blackWhitePresentsCount[0];
                long whitePresents = blackWhitePresentsCount[1];

                long blackCost = bCwCZ[0];
                long whiteCost = bCwCZ[1];
                long conversionCost = bCwCZ[2];

                System.Numerics.BigInteger total = (blackPresents * Math.Min(blackCost, whiteCost + conversionCost)) +
                    (whitePresents * Math.Min(whiteCost, blackCost + conversionCost));

                Console.WriteLine(total);
            }
        }
    }
}
