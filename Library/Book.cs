using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        public string title;
        public string author;
        public string isbn;

        public Book(string bookTitle, string bookAuthor, string bookIsbn)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookIsbn;
        }
        void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {title}\nAuthor: {author}\nISBN: {isbn}\n");
        }
    }
}
