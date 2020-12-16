using System;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] myNumbers = new int[num];
            myNumbers = Console.ReadLine().Split(' ').Select(int.Parse)
                .ToArray();

            decimal positive = myNumbers.Where(n => n > 0).Count();
            decimal negative = myNumbers.Where(n => n < 0).Count();
            decimal zeros = myNumbers.Where(n => n == 0).Count();
            decimal positiveResult = positive / num;
            decimal negativeResult = negative / num;
            decimal zeroResult = zeros / num;
            Console.WriteLine($"{positiveResult:f6}");
            Console.WriteLine($"{negativeResult:f6}");
            Console.WriteLine($"{zeroResult:f6}");
        }
    }
}