using System;
using System.Linq;

namespace LibraryFine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dayMonthYearRETURNED = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] DUE = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int day = dayMonthYearRETURNED[0];
            int month = dayMonthYearRETURNED[1];
            int year = dayMonthYearRETURNED[2];

            if (year > DUE[2])
            {
                Console.WriteLine(10000);
            }
            else if (month > DUE[1] && year == DUE[2])
            {
                var monthsLate = month - DUE[1];
                Console.WriteLine(500*monthsLate);
            }
            else if (day > DUE[0] && month == DUE[1] && year == DUE[2])
            {
                Console.WriteLine(15*(day - DUE[0]));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
