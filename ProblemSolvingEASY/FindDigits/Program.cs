using System;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                int current = int.Parse(Console.ReadLine());
                int theNumber = current;
                int count = 0;
                while (current != 0)
                {
                    int lastDigit = current % 10;
                    if (lastDigit == 0)
                    {
                        current /= 10;
                        continue;
                    }
                    if (theNumber % lastDigit == 0)
                    {
                        count++;
                    }
                    current /= 10;
                }
                Console.WriteLine(count);
            }
        }
    }
}
