using System;
using System.Linq;

namespace SimpleArraySum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] myArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = myArray.Sum();
            Console.WriteLine(sum);
        }
    }
}
