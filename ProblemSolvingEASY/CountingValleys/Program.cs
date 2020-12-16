using System;

namespace CountingValleys
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string steps = Console.ReadLine();
            int lvl = 0;
            int countValleys = 0;

            for (int i = 0; i < n; i++)
            {
                if (steps[i] == 'U') lvl++;
                else lvl--;

                if (lvl == 0 && steps[i] == 'U')
                {
                    countValleys++;
                }
            }

            Console.WriteLine(countValleys);
        }
    }
}