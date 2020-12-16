using System;
using System.Linq;

namespace CutTheSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int[] sticks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = sticks.Length;

            while (true)
            {
                if (sticks.Length == 0)
                {
                    return;
                }
                Console.WriteLine(sticks.Length);
                int shortest = sticks.Min();
                sticks = sticks.Where(n => n != shortest).ToArray();
                sticks = sticks.Select(n => n - shortest).ToArray();
            }
        }
    }
}
