using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        //FIELDS

        //PROPERTIES

        public List<Book> Books { get; set; }

        public string LibraryName { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }


        //CONSTRUCTORS

        public Library(string libraryName, string streetAddress, string city, string state, string zip, List<Book> books)
        {
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Books = books;
        }

        //METHODS
        public override string ToString()
        {
            string booksNeeded = "";
            foreach (Book b in Books)
            {
                booksNeeded += b + "\n";
            }
            return string.Format("\nLibrary: {0}\n" +
                "Address: {1} {2} {3} {4}\n" +
                "Stock: {5}", LibraryName, StreetAddress, City, State, Zip, booksNeeded);

        }
    }
}
