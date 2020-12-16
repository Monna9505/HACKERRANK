using System;
using System.Collections.Generic;
using System.Linq;

namespace PickingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).OrderBy(n => n).ToList();
            int bestLen = 0;
            List<int> final = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    int diff = Math.Abs(arr[i] - arr[j]);
                    if (diff <= 1)
                    {
                        final.Add(arr[j]);
                    }
                }
                if (final.Count > 1)
                {
                    arr.RemoveRange(0, final.Count - 1);
                    for (int m = 0; m < final.Count; m++)
                    {
                        for (int n = 0; n < final.Count; n++)
                        {
                            if ((Math.Abs(final[m] - final[n]) <= 1) == false)
                            {
                                final.Remove(final[m]);
                                break;
                            }
                        }
                    }
                }
                
                if (final.Count > bestLen)
                {
                    bestLen = final.Count;
                }

                final.Clear();
            }

            Console.WriteLine(bestLen);
        }
    }
}
