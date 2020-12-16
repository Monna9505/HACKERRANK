using System;
using System.Linq;

namespace TheHurdleRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hurdlesAndDansHeight = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] hurdleHeight = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = 0;

            int max = hurdleHeight.Max(n => n);
            if (max > hurdlesAndDansHeight[1])
            {
                result = max - hurdlesAndDansHeight[1];
                Console.WriteLine(result);
                return;
            }

            Console.WriteLine(result);
        }
    }
}
