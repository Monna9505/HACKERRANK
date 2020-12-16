using System;
using System.Linq;

namespace CompareTheTriplets
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] alice = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] bob = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = new int[2];

            for (int i = 0; i < alice.Length; i++)
            {
                if (alice[i] > bob[i])
                {
                    result[0]++;
                }
                else if(bob[i] > alice[i])
                {
                    result[1]++;
                }
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
