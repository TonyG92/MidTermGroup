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
            Console.WriteLine("Welcome to four codemen library! Enter y to continue.");
            response = Console.ReadLine();

            

            while (response == "y")
            {
                Console.Clear();
                Console.WriteLine("Please select either Author, Title , Genre or type All to get a list of all our books.");
                choice = Console.ReadLine().ToLower();


                

                switch (choice)
                {


                    // checking out and adding new books 
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
                    case "checkout":
                        BookMethods.ListBooks(books);
                        Console.WriteLine("What book do you want to check out");
                        BookMethods.BookDue(books.ElementAt(int.Parse(Console.ReadLine())+1));
                        break;
                    case "addbook":
                        Console.WriteLine("What book would you like to add to the library?");
                        Console.WriteLine("Enter Title");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter Author");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter Genre");
                        string genre = Console.ReadLine();
                        break;
                    default:
                        BookMethods.DisplaySpecific(books, "All", "");
                        break;
                }

                Console.Write("What category are you interested in? ");


                userInput = Console.ReadLine();

                foreach (Book book in books)

                foreach (Book m in books)

                {
                    if (userInput.ToLower() == book.Title)
                    {
                        Console.WriteLine(book.Title);
                    }

                }

                Console.WriteLine("Would you like to continue? (y/n) ");


                response = Console.ReadLine();


                foreach (Book book in books)
                {
                    Console.WriteLine(book.Author + book.Title);
                }



                Console.WriteLine("Would you like to continue? (y/n) ");
                response = Console.ReadLine();

            }
        }
    }
}