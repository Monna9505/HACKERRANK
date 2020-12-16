using System;
using System.Linq;

namespace CatAndAMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] positions = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int catA = positions[0];
                int catB = positions[1];
                int mouseC = positions[2];

                int A = Math.Abs(catA - mouseC);
                int B = Math.Abs(catB - mouseC);

                if (A < B)
                {
                    Console.WriteLine("Cat A");
                }
                else if (B < A)
                {
                    Console.WriteLine("Cat B");
                }
                else
                {
                    Console.WriteLine("Mouse C");
                }
            }
        }
    }
}
