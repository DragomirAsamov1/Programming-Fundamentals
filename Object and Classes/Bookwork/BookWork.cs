using System;
using ClassBook;

namespace Bookwork
{
    public class BookWork
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            string book1Title = "Обектно ориентирано програмиране";
            int book1Total = 15;
            book1.title = book1Title;
            book1.total = book1Total;
            Console.WriteLine("Библиотека на {0}", book1.library);
            Console.WriteLine("Заглавие на книга 1: {0}", book1.title);
            Console.WriteLine("Брой екземпляри на книга 1: {0}", book1.total);

            string book2Title = "Операционни системи";
            int book2Total = 25;
            Book book2 = new Book(book2Title, book2Total);
            string book2Library = "Филиал на УниБИТ";
            book2.library = book2Library;
            Console.WriteLine("");
            Console.WriteLine("Библиотека {0}", book2.library);
            Console.WriteLine("Заглавие на книга 2: {0}", book2.title);
            Console.WriteLine("Брой екземпляри на книга 2: {0}", book2.total);
            Console.ReadKey();
        }
    }
}
