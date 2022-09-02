using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryv2
{
    internal class Manager
    {
        //making a book list
        private List<Book> books = new List<Book>();

        // properties
        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        //Constructor
        public Manager()
        {
            Book book1 = new Book("Harry Potter", "J.K Rowling");
            Book book2 = new Book("Lord of the Rings", "Tolkien");
            Book boob3 = new Book("Bible", "Moses");

            books.Add(book1);
            books.Add(book2);
            books.Add(boob3);

        }


    }
}
