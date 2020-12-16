using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split(' ').Select(long.Parse).ToList();
            long total = numbers.Sum();
            long min = total - numbers.Max();
            long max = total - numbers.Min();

            Console.WriteLine(min + " " + max);
        }
    }
}