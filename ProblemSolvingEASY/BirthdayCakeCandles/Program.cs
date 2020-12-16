using System;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] candles = new int[num];
            candles = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();

            int max = candles.Max();
            int amount = 0;
            for (int i = 0; i < candles.Length; i++)
            {
                if (max == candles[i])
                {
                    amount++;
                }
            }

            Console.WriteLine(amount);
        }
    }
}