using System;
using System.Linq;

namespace HalloweenSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pdms = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int price = pdms[0];
            int deduction = pdms[1];
            int m = pdms[2];
            int dollarInPocket = pdms[3];
            int numberGames = 0;

            while (dollarInPocket > 0)
            {
                if (dollarInPocket < price)
                {
                    break;
                }
                if (dollarInPocket < m)
                {
                    break;
                }

                if (price > m)
                {
                    dollarInPocket -= price;
                    price -= deduction;
                }
                else
                {
                    dollarInPocket -= m;
                }

                numberGames++;
            }

            Console.WriteLine(numberGames);
        }
    }
}
