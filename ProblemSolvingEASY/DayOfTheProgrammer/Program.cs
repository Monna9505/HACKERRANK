using System;

namespace DayOfTheProgrammer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            int sevenMonths = 215;
            int february = 0;

            //Julian Calendar
            if (year >= 1700 && year <= 1917)
            {
                february = year % 4 == 0 ? 29 : 28;
            }

            else if (year == 1918)
            {
                february = 15;
            }

            else if (year >= 1919 && year <= 2700)
            {
                february = year % 400 == 0 || year % 4 == 0 && year % 100 != 0 ? 29 : 28;
            }

            int day = 256 - (sevenMonths + february);

            Console.WriteLine($"{day}.09.{year}");
        }
    }
}