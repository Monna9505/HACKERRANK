using System;

namespace ViralAdvertising
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int peeps = 5;
            int totalPeople = 0;

            for (int i = 0; i < days; i++)
            {
                peeps = peeps / 2;
                totalPeople += peeps;
                peeps *= 3;
            }

            Console.WriteLine(totalPeople);
        }
    }
}
