using System;
using System.Collections.Generic;

namespace ModifiedKaprekarNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long downLimit = long.Parse(Console.ReadLine());
            long upLimit = long.Parse(Console.ReadLine());
            List<long> numbers = new List<long>();

            for (long i = downLimit; i <= upLimit; i++)
            {
                string currentNum = Math.Pow(i,2).ToString();
                string firstPart = currentNum.Substring(0, currentNum.Length / 2);
                string secondPart = currentNum.Substring(currentNum.Length / 2);
                var first = firstPart != "" ? long.Parse(firstPart) : 0;
                var second = secondPart != "" ? long.Parse(secondPart) : 0;

                if (first + second == i)
                {
                    numbers.Add(i);
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("INVALID RANGE");
                return;
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
