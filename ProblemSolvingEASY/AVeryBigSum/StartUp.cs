using System;
using System.Linq;

namespace AVeryBigSum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            long[] myArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long sum = myArray.Sum();
            Console.WriteLine(sum);
        }
    }
}
