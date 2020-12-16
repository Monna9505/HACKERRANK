using System;
using System.Linq;

namespace JumpingOnTheCloudsRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            var nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int energyLevel = 100;
            int i = 0;

            do
            {
                energyLevel--;
                if (i + nk[1] >= array.Length)
                {
                    i = 0;
                }
                else
                {
                    i += nk[1];
                }

                if (array[i] == 1)
                {
                    energyLevel -= 2;
                }
            } while (i != 0);
            
            Console.WriteLine(energyLevel);
        }
    }
}
