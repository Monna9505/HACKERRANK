using System;
using System.Linq;

namespace MigratoryBirds
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] birds = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] types = new int[5];
            int max = -1;

            for (int i = 0; i < birds.Length; i++)
            {
                switch (birds[i])
                {
                    case 1:
                        types[0]++;
                        break;
                    case 2:
                        types[1]++;
                        break;
                    case 3:
                        types[2]++;
                        break;
                    case 4:
                        types[3]++;
                        break;
                    case 5:
                        types[4]++;
                        break;
                }
            }

            int index = 0;
            for (int i = 0; i < types.Length; i++)
            {
                if (max < types[i])
                {
                    max = types[i];
                    index = i + 1;
                }
            }

            Console.WriteLine(index);
        }
    }
}