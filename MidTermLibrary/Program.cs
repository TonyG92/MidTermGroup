﻿using System;
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
            string userInput;
            string response = "y";
            Console.WriteLine("Welcome to four codemen library!");

            while (response == "y")
            {
                Console.WriteLine("Please select a category to sift through or type 6 to get a list of all our books.");

                Console.WriteLine(string.Format($"{0,15}{1,15}{2,15}{3,15}{4,15}{5,15}{6,15}", "Mystery", "Fantasy", "Thriller", "Fiction", "Detective"));

                Console.Write("What category are you interested in? ");

                userInput = Console.ReadLine();
                foreach (Book m in books)
                {
                    if (userInput.ToLower() == m.Title)
                    {
                        Console.WriteLine(m.Title);
                    }

                }

                Console.WriteLine("Would you like to continue? (y/n) ");

                response = Console.ReadLine();


                foreach (Book book in books)
                {
                    Console.WriteLine(book.Author + book.Title);
                }
            }
        }
    }
}