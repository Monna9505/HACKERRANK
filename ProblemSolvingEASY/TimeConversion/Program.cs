using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string hour = Console.ReadLine();
            DateTime twFh = DateTime.Parse(hour);
            Console.WriteLine(twFh.ToString("HH:mm:ss"));


            string time = Console.ReadLine();
            var newtime = DateTime.Parse(time);
            Console.WriteLine(newtime.ToString("hh:mm:ss"));

        }
    }
}