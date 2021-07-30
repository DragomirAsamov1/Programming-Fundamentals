using System;
using ClassBook;

namespace ClassBookDemo
{
    public class BookWork
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Обектно ориентирано програмиране";
            book1.Total = 15;
            book1.library = "пишкипари";
            Book book2 = new Book();
            Console.WriteLine(book1.library+" " + book2.library);
            Console.WriteLine("Заглавие: " + book1.Title);
            Console.WriteLine("Брой от екземплярите в библиотеката: " + book1.Total);
            Console.ReadKey();
        }
    }
}
