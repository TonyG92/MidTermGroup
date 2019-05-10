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

            while (response == "y")
            {
                Console.WriteLine("Please select either Author, Title , Genre or type All to get a list of all our books.");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "Author":
                        Console.Write("Please enter in an Author: ");
                        BookMethods.DisplaySpecific(books, "Author", Console.ReadLine());
                        break;
                    case "Title":
                        Console.Write("Please enter in n Title: ");
                        BookMethods.DisplaySpecific(books, "Title", Console.ReadLine());
                        break;
                    case "Genre":
                        Console.Write("Please enter in a Genre");
                        BookMethods.DisplaySpecific(books, "Genre", Console.ReadLine());
                        break;
                    default:
                        BookMethods.DisplaySpecific(books, "All", "");
                        break;

                }
                

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