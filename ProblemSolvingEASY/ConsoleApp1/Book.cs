using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ConsoleApp1
{
    class Book
    {
        private int bookId;
        private int pages;
        private double price;

        public void Get(int book_id, int pages, double price)
        {
            BookId = book_id;
            Pages = pages;
            Price = price;
        }

        public void Show()
        {
            Console.WriteLine(this.BookId);
            Console.WriteLine(this.Pages);
            Console.WriteLine(this.Price);
        }

        public double GetPrice()
        {
            return this.Price;
        }

        public int BookId
        { 
            get { return this.bookId; }
            set
            {
                this.bookId = value;
            }
        }

        public int Pages
        {
            get { return this.pages; }
            set
            {
                this.pages = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                this.price = value;
            }
        }
    }
}
