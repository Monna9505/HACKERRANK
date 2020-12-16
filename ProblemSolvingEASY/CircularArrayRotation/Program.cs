using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CircularArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nkq = Array.ConvertAll(Console.ReadLine()
                .Split(), temp => Convert.ToInt32(temp));
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] queries = new int[nkq[2]];

            for (int i = 0; i < nkq[2]; i++)
            {
                int query = int.Parse(Console.ReadLine());
                queries[i] = query;
            }

            for (int i = 0; i < nkq[1]; i++)
            {
                int current = numbers[numbers.Count - 1];
                numbers.Insert(0, current);
                numbers.RemoveAt(numbers.Count - 1);
            }


            for (int i = 0; i < queries.Length; i++)
            {
                Console.WriteLine(numbers[queries[i]]);
            }
        }
    }
}
