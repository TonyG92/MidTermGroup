using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLibrary
{
    class BookMethods 
    {
        //Data Members -andre
        
        private string titlekeyword;

        //Properties -andre
       
        public string TiteleKeyWord
        {
            set
            {
                titlekeyword = value;
            }
            get
            {
                return titlekeyword;
            }
        }
        //Constructor -amdre

        public BookMethods(string _titlekeyword) 
        {
            titlekeyword = _titlekeyword;
        }        

        //methods bookdue -tony
        public void BookDue(Book book)
         {
            book.CheckedIn = false;
            book.DueDate = DateTime.Now.AddDays(14);
         }
<<<<<<< HEAD
=======

>>>>>>> 637cbe86d2209ae7e7739ca379011997a67982c9

        
        public void BookAdd(List<Book> books, string inputTitle, string inputAuthor, string inputGenre)
        {
            Book book = new Book(inputTitle, inputAuthor, inputGenre);

            books.Add(book);

        }

  
        // a method bookvalidation -andre
<<<<<<< HEAD

=======
>>>>>>> 637cbe86d2209ae7e7739ca379011997a67982c9
        public static bool BookValidation(List<Book> books, string input)
        {
            foreach (Book book in books)
            {
                if (input == book.Title)
                {
                    return true;
                }
            }
            return false;
        }
<<<<<<< HEAD

=======
>>>>>>> 637cbe86d2209ae7e7739ca379011997a67982c9

    }
}
