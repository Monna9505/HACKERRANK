using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger final = 1;

            for (int i = 2; i <= number; i++)
            {
                final *= i;
            }

            Console.WriteLine(final);
        }
    }
}
