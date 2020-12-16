using System;
using System.Collections.Generic;

namespace SmartNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                int factors = FindFactors(currentNumber).Count;

                if (factors % 2 != 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        private static List<int> FindFactors(int currentNumber)
        {
            int max = (int)Math.Sqrt(currentNumber);
            var factors = new List<int>();

            for (int factor = 1; factor <= max; factor++)
            {
                if (currentNumber % factor == 0)
                {
                    factors.Add(factor);
                }
            }

            return factors;
        }
    }
}
