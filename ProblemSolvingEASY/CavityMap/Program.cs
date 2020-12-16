using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CavityMap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            
            FillMatrix(matrix, n);
            
            for (int i = 0; i < n-1; i++)
            {
                int[] currentArr1 = matrix[i];
                for (int j = 1; j < currentArr1.Length-1; j++)
                {
                    if (i == 0)
                    {
                        int[] arr = matrix[i + 1];
                        if (Check(j,currentArr1,i,arr))
                        {
                            currentArr1[j] = "X";
                        }
                    }
                    else if (i == n-1)
                    {
                        var arr = matrix[i - 1];
                        if (Check(j, currentArr1, i, arr))
                        {
                            currentArr1[j] = "X";
                        }
                    }
                    else
                    {
                        int[] arr = matrix[i - 1].ToArray();
                        int[] arr2 = matrix[i + 1].ToArray();
            
                        if (Check(j, currentArr1, i, arr) && 
                            (currentArr1[j] > arr2[j]))
                        {
                            currentArr1[j] = "X";
                        }
                    }
                }
            }
        }

        private static void FillMatrix(int[][] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split("").Select(int.Parse).ToArray();
                matrix[i] = arr;
            }
        }

        private static bool Check(int j, int[] currentArr1, int i, int[] arr)
        {
            bool isBiggerOrNo = false;
            if ((currentArr1[j] > currentArr1[j + 1])
                        && (currentArr1[j] > currentArr1[j-1]))
            {
                if (currentArr1[j] > arr[j])
                {
                    isBiggerOrNo = true;
                }
            }

            return isBiggerOrNo;
        }
    }
}
