using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLibrary
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Book> books = SavedBooks.FindBooks();
            foreach (Book book in books)
            {
                Console.WriteLine(book.Author + book.Title);
            }


        }
    }
}
