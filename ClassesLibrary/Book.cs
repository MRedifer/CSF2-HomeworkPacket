using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        private string _title;

        private string _author;

        private int _numberOfPages;


        public string Title { get; set; }

        public string Author { get; set; }

        public int NumberOfPages { get; set; }


        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public override string ToString()
        {
            return string.Format("Title: {0}\nAuthor: {1}\nNumber of Pages: {2}", Title, Author, NumberOfPages);
        }
    }
}
