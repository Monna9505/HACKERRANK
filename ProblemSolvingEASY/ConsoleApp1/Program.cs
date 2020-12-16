using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book firstBook = new Book();
            firstBook.Get(2, 4, 22.8);

            Book secondBook = new Book();
            firstBook.Get(6, 44, 5.4);


            if (firstBook.GetPrice() > secondBook.GetPrice())
            {
                firstBook.Show();
            }
            else
            {
                secondBook.Show();
            }
        }
    }
}
