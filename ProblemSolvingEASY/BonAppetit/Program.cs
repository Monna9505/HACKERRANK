using System;
using System.Linq;

namespace BonAppetit
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int refund = int.Parse(Console.ReadLine());
            int unwantedItem = items[nk[1]];

            long sum = items.Sum();
            sum = (sum - unwantedItem) / 2;

            if (sum == refund)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(refund - sum);
            }
        }
    }
}