using System;

namespace DrawingBook
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pageToTurnTo = int.Parse(Console.ReadLine());
            int result = Math.Min(pageToTurnTo / 2, (pages / 2) - (pageToTurnTo / 2));

            Console.WriteLine(result);
        }
    }
}