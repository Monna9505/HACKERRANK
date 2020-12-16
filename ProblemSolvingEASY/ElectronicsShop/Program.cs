using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicsShop
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] bnm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int budget = bnm[0];
            var keyboardPrices = Console.ReadLine().Split().Select(int.Parse).ToList();
            var USBPrices = Console.ReadLine().Split().Select(int.Parse).ToList();
            int max = -1;

            for (int i = 0; i < keyboardPrices.Count; i++)
            {
                for (int j = 0; j < USBPrices.Count; j++)
                {
                    if (USBPrices[j] + keyboardPrices[i] <= budget
                        && USBPrices[j] + keyboardPrices[i] > max)
                    {
                        max = USBPrices[j] + keyboardPrices[i];
                    }
                }
            }

            Console.WriteLine(max);
        }
    }
}