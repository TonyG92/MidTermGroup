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
            string userInput;
            string response = "y";
            string choice = "";
            Console.WriteLine("Welcome to four codemen library!");
            response = Console.ReadLine();

            List<Book> books = SavedBooks.FindBooks();
            foreach (Book book in books)
            {
                Console.WriteLine(book.Author + book.Title);
            }

            while (response == "y")
            {
                Console.WriteLine("Please select either Author, Title , Genre or type All to get a list of all our books.");
                choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "author":
                        Console.Write("Please enter in an Author: ");
                        BookMethods.DisplaySpecific(books, "Author", Console.ReadLine());
                        break;
                    case "title":
                        Console.Write("Please enter in a Title: ");
                        BookMethods.DisplaySpecific(books, "Title", Console.ReadLine());
                        break;
                    case "genre":
                        Console.Write("Please enter in a Genre");
                        BookMethods.DisplaySpecific(books, "Genre", Console.ReadLine());
                        break;
                    default:
                        BookMethods.DisplaySpecific(books, "All", "");
                        break;

                }
<<<<<<< HEAD
                

                Console.Write("What category are you interested in? ");

                userInput = Console.ReadLine();
<<<<<<< HEAD
                foreach (Book book in books)
=======
                foreach (Book m in books)
>>>>>>> 91080d28e0dc1272fbc95786f510e3bfb7ed997d
                {
                    if (userInput.ToLower() == book.Title)
                    {
                        Console.WriteLine(book.Title);
                    }

                }

                Console.WriteLine("Would you like to continue? (y/n) ");

<<<<<<< HEAD
=======
                response = Console.ReadLine();


                foreach (Book book in books)
                {
                    Console.WriteLine(book.Author + book.Title);
                }
>>>>>>> 91080d28e0dc1272fbc95786f510e3bfb7ed997d
=======

                Console.WriteLine("Would you like to continue? (y/n) ");
                response = Console.ReadLine();
>>>>>>> 58d93cc538f71e68ad31489b5074e1afa2ff7b6d
            }
        }
    }
}