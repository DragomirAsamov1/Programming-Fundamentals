using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Pr_01_01
{
    class BookDemo
    {
        static void Main(string [] args)
        {
            Book firstBook = new Book("Основи на програмирането");
            firstBook.Total = 10;
            Book secondBook = new Book();
            secondBook.Title = "Програмиране на C#";
            secondBook.Total = 20;

            Book[] books = new Book[] { firstBook, secondBook };

            foreach (Book book in books)
            {
                book.ViewBook();
                Console.WriteLine("");
            }
        }
    }
}
