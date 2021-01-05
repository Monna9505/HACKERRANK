using System;
using System.Collections.Generic;
using System.Linq;

namespace LonelyInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).OrderBy(p => p).ToList();
            bool even = true;
            int current = 0;

            while (true)
            {
                current = arr[0];

                if (arr.Count == 1)
                {
                    Console.WriteLine(current);
                    return;
                }
                else if (current == arr[1])
                {
                    even = true;
                    arr.RemoveAll(p => p == current);
                }
                else
                {
                    Console.WriteLine(current);
                    return;
                }
            }
        }
    }
}

