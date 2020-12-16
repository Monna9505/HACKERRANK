using System;
using System.Linq;

namespace Kangaroo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] x1v1x2v2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x1 = x1v1x2v2[0];
            int v1 = x1v1x2v2[1];
            int x2 = x1v1x2v2[2];
            int v2 = x1v1x2v2[3];

            JumpJump(x1, x2, v1, v2);
        }

        private static void JumpJump(int x1, int x2, int v1, int v2)
        {
            if (x1 > x2)
            {
                while (x2 < x1)
                {
                    x1 += v1;
                    x2 += v2;
                }
            }
            else
            {
                while (x1 < x2)
                {
                    x1 += v1;
                    x2 += v2;
                }
            }

            if (x1 == x2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}