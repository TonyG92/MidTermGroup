﻿using System;
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

<<<<<<< HEAD
        
=======
        //methods bookdue -tony
>>>>>>> 91080d28e0dc1272fbc95786f510e3bfb7ed997d
        public void BookDue(Book book)
         {
            book.CheckedIn = false;
            book.DueDate = DateTime.Now.AddDays(14);
         }
 
        public void BookAdd(List<Book> books, string inputTitle, string inputAuthor, string inputGenre)
        {
            Book book = new Book(inputTitle, inputAuthor, inputGenre);

            books.Add(book);

        }

  
        // a method bookvalidation -andre
         
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

        // - tony
        public static void Display(Book book)
        {
           
                Console.WriteLine($"Book title: {book.Title}");
                Console.WriteLine($"Book author: {book.Author}");
                Console.WriteLine($"Book genre: {book.Genre}");
                Console.WriteLine("-------");
            
        }


        // -tony
        public static void DisplaySpecific(List<Book> books, string search, string input)
        {
            switch (search)
            {
                case "Title": foreach(Book book in books)
                    {
                        if(input == book.Title)
                        {
                            Display(book);
                        }
                    }
                    break;
                case "Author":
                    foreach (Book book in books)
                    {
                        if (input == book.Author)
                        {
                            Display(book);
                        }
                    }
                    break;
                case "Genre":
                    foreach (Book book in books)
                    {
                        if (input == book.Genre)
                        {
                            Display(book);
                        }
                    }
                    break;
                case "All": foreach (Book book in books)
                    {
                            Display(book);
                    }
                    break;
            }
        }


        




    }
}
