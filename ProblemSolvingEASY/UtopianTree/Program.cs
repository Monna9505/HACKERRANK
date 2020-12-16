using System;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());
            int tree = 1;
            

            for (int i = 1; i <= cycles; i++)
            {
                int cycle = int.Parse(Console.ReadLine());
                for (int j = 1; j <= cycle; j++)
                {
                    if (j % 2 != 0)
                    {
                        tree *= 2;
                    }
                    else
                    {
                        tree += 1;
                    }
                }
                Console.WriteLine(tree);
                tree = 1;
            }
        }
    }
}
