using System;
using System.Linq;

namespace AppleAndOrange
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] housePoints = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] appleOrangeTree = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] applesOranges = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] apples = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] oranges = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int applesFallen = 0;
            int orangesFallen = 0;

            FuitsFallen(oranges, appleOrangeTree, apples, housePoints, ref applesFallen, ref orangesFallen);

            Console.WriteLine(applesFallen);
            Console.WriteLine(orangesFallen);
        }

        private static void FuitsFallen(int[] oranges, int[] appleOrangeTree, int[] apples, int[] housePoints, ref int applesFallen, ref int orangesFallen)
        {
            for (int i = 0; i < apples.Length; i++)
            {
                if (appleOrangeTree[0] + apples[i] >= housePoints[0]
                    && appleOrangeTree[0] + apples[i] <= housePoints[1])
                {
                    applesFallen++;
                }
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                if (appleOrangeTree[1] + oranges[i] >= housePoints[0]
                    && appleOrangeTree[1] + oranges[i] <= housePoints[1])
                {
                    orangesFallen++;
                }
            }
        }
    }
}