using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            int rightSum = 0;
            int leftSum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ')
                    .Select(int.Parse).ToArray();
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                rightSum += matrix[i][i];
                leftSum += matrix[matrix.Length - 1 - i][i];
            }

            int sum = Math.Abs(rightSum - leftSum);
            Console.WriteLine(sum);
        }
    }
}