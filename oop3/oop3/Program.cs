using System;

namespace oop3
{
    class Book
    {
        private string Author;
        private string Title;
        private int Quantity;
        private bool Collection;
        public Book(string Title, bool Collection)
        {
            this.Author = "А.С Пушкин";
            this.Title = Title;
            this.Quantity = 250;
            this.Collection = Collection;
        }
        public Book(string Author, string Title, int Quantity, bool Collection)
        {
            this.Author = Author;
            this.Title = Title;
            this.Quantity = Quantity;
            this.Collection = Collection;
        }
        public void BOOK()
        {
            Console.WriteLine("Автор: " + Author);
            Console.WriteLine("Название книги: " + Title);
            Console.WriteLine("Кол-во страниц: " + Quantity);
            Console.WriteLine("Коллекционное издание: " + Collection);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book newBookClear = new Book("-",false);
            newBookClear.BOOK();
            Console.WriteLine("----------------------------");
            Book newBook = new Book("Л.Н Толстой", "Война и мир", 1300, true);
            newBook.BOOK();
            Console.ReadLine();
        }
    }
}
