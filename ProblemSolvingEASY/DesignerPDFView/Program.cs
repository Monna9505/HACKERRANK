using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignerPDFView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<string> alphabet = new List<string>(){ "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            string letters = Console.ReadLine();
            int[] valueLetters = new int[letters.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                var letter = letters[i].ToString();
                int index = alphabet.LastIndexOf(letter);
                valueLetters[i] = numbers[index];
            }

            int highest = valueLetters.Max();
            int result = highest * letters.Length;

            Console.WriteLine(result);
        }
    }
}
