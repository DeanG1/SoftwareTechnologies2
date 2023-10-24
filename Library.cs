using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAdapter
{
    class Library
    {
        protected string BookId;
        protected string nameOfBook;
        protected string author;
        protected string genre;
        protected string year;

        public Library(string bookId) 
        {
            this.BookId = bookId;   
        }
        public virtual void Display() 
        {
            Console.WriteLine("\nBook: {0} ------", BookId);
        }


    }
}
