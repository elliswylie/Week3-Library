using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {
        private string title;
        private string author;
        private string isbn;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set
            {
                // Checks if any character in the incoming string is a digit
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }

        public string ISBN
        {
            get { return isbn; }
            set
            {
                // Checks that the incoming string is not blank
                if (value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }

        public Book(string bookTitle, string bookAuthor, string bookIsbn)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookIsbn;
        }
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {title}\nAuthor: {author}\nISBN: {isbn}\n");
        }
    }
}
