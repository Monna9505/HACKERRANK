using System;
using System.Linq;

namespace FindTheMedian
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split().Select(int.Parse).OrderBy(n => n).ToArray();
            int median = nums[nums.Length / 2];

            Console.WriteLine(median);
        }
    }
}
