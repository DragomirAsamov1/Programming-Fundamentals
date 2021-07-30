using System;

namespace ClassBook
{
    public class Book
    {
        internal string library;
        internal string title;
        internal int total;
        public Book()
        {
            library = "УниБИТ";
        }
        public Book(string title, int total)
        {
            this.title = title;
            this.total = total;
        }
    }
}
