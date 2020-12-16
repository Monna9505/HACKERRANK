using System;
using System.Linq;

namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());


            for (int i = 0; i < testCases; i++)
            {
                var students = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var arrival = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int onTimeStudents = 0;

                for (int j = 0; j < arrival.Length; j++)
                {
                    if (arrival[j] <= 0)
                    {
                        onTimeStudents++;
                    }
                }

                if (onTimeStudents >= students[1])
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
