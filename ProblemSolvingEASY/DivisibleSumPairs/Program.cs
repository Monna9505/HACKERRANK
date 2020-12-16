using System;
using System.Linq;

namespace DivisibleSumPairs
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] myArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int theNumber = nk[1];
            int countPairs = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    int sum = myArray[i] + myArray[j];
                    if (sum % theNumber == 0)
                    {
                        countPairs++;
                    }
                }
            }

            Console.WriteLine(countPairs);
        }
    }
}