﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLibrary
{
    class BookMethods 
    {
        //Data Members
        
        private string titlekeyword;

        //Properties
       
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
        //Constructor

        public BookMethods(string _titlekeyword) 
        {
            titlekeyword = _titlekeyword;
        }        

        //methods
        public void BookDue(Book book)
         {
            book.CheckedIn = false;
            book.DueDate = DateTime.Now.AddDays(14);
         }


        // check if the input even is a book method



        // a method for adding a book
        public void BookAdd(List<Book> books, string userInput)
        {
            
        }




        


         
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


    }
}
