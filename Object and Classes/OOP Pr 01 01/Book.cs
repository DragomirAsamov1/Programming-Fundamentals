using System;

namespace OOP_Pr_01_01
{
    class Book
    {
        private string title;
        private int total;
        public Book()
        {
        }
        public Book(string title)
        {
            this.title = title;
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public int Total
        {
            get { return this.total; }
            set { this.total = value; }
        }

        public void ViewBook()
        {
            Console.WriteLine("Заглавие на книгата: {0}",this.title);
            Console.WriteLine("Брой екземпляри в библиотеката: {0}", this.total);
        }

    }
}
