using System;
using System.Linq;

namespace MinimumDistances
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        min = Math.Min(min,Math.Abs(i - j));
                    }
                }
            }

            if (min == int.MaxValue)
            {
                Console.WriteLine(-1);
                return;
            }

            Console.WriteLine(min);
        }
    }
}
