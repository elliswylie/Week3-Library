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

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {title}\nAuthor: {author}\nISBN: {isbn}\n");
        }
    }
}
