﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public static void BookDue(Book book)
         {
            if (book.CheckedIn)
            {
                book.CheckedIn = false;
                book.DueDate = DateTime.Now.AddDays(14);
            }
            else
            {
                book.CheckedIn = true;
                book.DueDate = DateTime.Now;
            }
         }
 
        public static void BookAdd(List<Book> books, string inputTitle, string inputAuthor, string inputGenre)
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
            Console.WriteLine($"Status: {(book.CheckedIn ? "On shelves": "Out until "+book.DueDate.ToString("MM/dd/yyyy"))}");
            Console.WriteLine("-------");
            
        }

        public static void ListBooks(List<Book> books)
        {//Luke
            foreach (Book book in books)
            {
                Console.WriteLine($"{books.IndexOf(book)+1}. {book.Title} - {(book.CheckedIn ? "On Shelf":"Checked Out")}");
            }
        }

        public static bool IsMatch(string input, string target)
        {
            string[] wanted = target.ToLower().Split(' ');
            string regexOfTarget = "";

            foreach (string word in wanted)
            {
                
                regexOfTarget = regexOfTarget+$@"\b({word})\b|";
            }

            return Regex.IsMatch(input.ToLower(), $@"\b(\w*({regexOfTarget}!)\w*)\b");
        }

        // -tony
        public static void DisplaySpecific(List<Book> books, string search, string input)
        {
            switch (search)
            {
                case "Title": foreach(Book book in books)
                    {
                        if(IsMatch(input, book.Title))
                        {
                            Display(book);
                        }
                    }
                    break;
                case "Author":
                    foreach (Book book in books)
                    {
                        if (IsMatch(input, book.Author))
                        {
                            Display(book);
                        }
                    }
                    break;
                case "Genre":
                    foreach (Book book in books)
                    {
                        if (IsMatch(input, book.Genre))
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
