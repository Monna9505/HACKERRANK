using System;
using System.Collections.Generic;
using System.Linq;

namespace SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> socks = Console.ReadLine().Split().Select(int.Parse).ToList();
            int pairs = 0;
            bool pair = false;

            for (int i = 0; i < socks.Count; i++)
            {
                if (pair)
                {
                    i = 0;
                }
                pair = false;
                for (int j = i+1; j < socks.Count; j++)
                {
                    if (socks[i] == socks[j])
                    {
                        pairs++;
                        socks.RemoveAt(j);
                        socks.RemoveAt(i);
                        pair = true;
                        break;
                    }
                }
            }

            Console.WriteLine(pairs);
        }
    }
}
