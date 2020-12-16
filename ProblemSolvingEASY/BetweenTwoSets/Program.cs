using System;
using System.Collections.Generic;
using System.Linq;

namespace BetweenTwoSets
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] numOfElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] m = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;

            for (int i = n[n.Length - 1]; i <= m[0]; i++)
            {
                bool isValid = true;
                for (int l = 0; l < n.Length; l++)
                {
                    if (i % n[l] != 0)
                    {
                        isValid = false;
                        break;
                    }
                }

                for (int j = 0; j < m.Length; j++)
                {
                    if (m[j] % i != 0)
                    {
                        isValid = false;
                    }
                }

                if (isValid)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}