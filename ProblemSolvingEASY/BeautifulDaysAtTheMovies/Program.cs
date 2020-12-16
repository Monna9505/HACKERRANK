using System;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace BeautifulDaysAtTheMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int beautifulDays = 0;


            for (int i = nums[0]; i <= nums[1]; i++)
            {
                int reversed = Reverse(i);
                int result = Math.Abs(i - reversed);

                if (result % nums[2] == 0)
                {
                    beautifulDays++;
                }
            }

            Console.WriteLine(beautifulDays);
        }

        private static int Reverse(int i)
        {
            int rev = 0;
            while (i != 0)
            {
                rev = rev * 10 + i % 10;
                i = i / 10;
            }
            return rev;
        }
    }
}
