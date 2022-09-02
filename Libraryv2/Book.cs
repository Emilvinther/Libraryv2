using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryv2
{
    internal class Book
    {
        //valueables
        private string title;
        private string author;

        //properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        //Constructor
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        //String override for printr
        public override string ToString()
        {
            return $"Title = {title}" +
                $"\nAuthor = {author}";
        }
    }
}
