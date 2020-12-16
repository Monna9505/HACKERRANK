using System;

namespace SolveMeFirst
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sum = SolveMeFirst(a,b);
            Console.WriteLine(sum);
        }

        public static int SolveMeFirst(int a, int b)
        {
            return a + b;
        }
    }
}
