using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayChocolate
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> chocolates = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] dayMonth = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = chocolates.Count;
            int count = 0;

            for (int i = 0; i < length; i++)
            {
                int sum = chocolates.Take(dayMonth[1]).Sum();
                chocolates.RemoveAt(0);

                if (sum == dayMonth[0])
                {
                    count++;
                }
                else if (chocolates.Count < dayMonth[1])
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}