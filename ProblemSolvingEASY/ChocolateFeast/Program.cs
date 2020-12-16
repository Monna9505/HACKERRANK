using System;
using System.Linq;

namespace ChocolateFeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                int[] ncm = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int moneyToSpend = ncm[0];
                int chocCost = ncm[1];
                int wrapperForChoco = ncm[2];

                int wrappers = 0;
                int totalChocoEaten = 0;

                while (moneyToSpend >= chocCost)
                {
                    moneyToSpend -= chocCost;
                    wrappers++;
                    totalChocoEaten++;

                    if (wrappers >= wrapperForChoco)
                    {
                        wrappers -= wrapperForChoco;
                        totalChocoEaten++;
                        wrappers++;
                    }
                }

                Console.WriteLine(totalChocoEaten);
            }
        }
    }
}
