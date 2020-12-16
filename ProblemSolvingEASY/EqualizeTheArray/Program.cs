using System;
using System.Linq;

namespace EqualizeTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            int numberOLD = 0;
            int wantedNum = 0;
            int oldCount = -1;

            for (int i = 0; i < integers.Length; i++)
            {
                numberOLD = integers[i];
                for (int j = 0; j < integers.Length; j++)
                {
                    int currentNum = integers[j];

                    if (numberOLD == currentNum)
                    {
                        count++;
                    }
                }

                if (count > oldCount)
                {
                    oldCount = count;
                    wantedNum = numberOLD;
                }
                count = 0;
            }

            integers = integers.Where(n => n != wantedNum).ToArray();
            int c = integers.Length;
            Console.WriteLine(c);
        }
    }
}
