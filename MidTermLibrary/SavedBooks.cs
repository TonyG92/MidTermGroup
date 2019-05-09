﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLibrary
{
    class SavedBooks
    {
        public static List<Book> FindBooks()
        {
            // making new book variable 
            List<Book> books = new List<Book>();
            //new pulls in file and reads each line in the txt file as a index
            string[] lines = System.IO.File.ReadAllLines($@"{System.IO.Directory.GetCurrentDirectory()}\booklist.txt");
            //for each line we are now calling it a book. we are now splitting them at each "/"
            foreach(string book in lines)
            {
                //splits each line at "/" going down
                string[] info = book.Split('/');
                //makes new book ( go to Book)
                //and follows pattern of title author genre
                Book toAdd = new Book(info[0], info[1], info[2]);
                //adds to new list 
                books.Add(toAdd);
            }

            return books;
        }
    }
}