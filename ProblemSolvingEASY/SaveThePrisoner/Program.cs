using System;
using System.Linq;
using System.Net.Security;

namespace SaveThePrisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
            int result = 0;
            
            for (int i = 0; i < tests; i++)
            {
                int[] nms = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int prisoners = nms[0];
                int sweets = nms[1];
                int chairNumber = nms[2];
            
                result = sweets + chairNumber - 1;
                if (result % prisoners == 0)
                {
                    Console.WriteLine(prisoners);
                }
                else
                {
                    Console.WriteLine(result%prisoners);
                }
            }
        }
    }
}
