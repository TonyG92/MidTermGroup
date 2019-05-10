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
            bool continuing = true;
            string choice = "";
            Console.WriteLine("Welcome to four codemen library!");

            do
            {
                Console.Clear();
                Console.WriteLine("1. Search by author" +
                    "\n2. Search by title keyword" +
                    "\n3. Search by genre" +
                    "\n4. Checkout a book" +
                    "\n5. Add a new book" +
                    "\n6. Display all titles with index" +
                    "\n7. Exit");
                choice = Console.ReadLine().ToLower();
                switch (choice)
                {


                    // checking out and adding new books 
                    case "1":
                        Console.Write("Please enter in an Author: ");
                        BookMethods.DisplaySpecific(books, "Author", Console.ReadLine());
                        break;
                    case "2":
                        Console.Write("Please enter in a Title: ");
                        BookMethods.DisplaySpecific(books, "Title", Console.ReadLine());
                        break;
                    case "3":
                        Console.Write("Please enter in a Genre: ");
                        BookMethods.DisplaySpecific(books, "Genre", Console.ReadLine());
                        break;
                    case "4":
                        BookMethods.ListBooks(books);
                        Console.WriteLine("What book would you like to checkout? ");

                        BookMethods.BookDue(books.ElementAt(int.Parse(Console.ReadLine()) + 1));
                        break;
                    case "5":
                        Console.WriteLine("What book would you like to add to the library?");

                        Console.WriteLine("Enter a title: ");
                        string title = Console.ReadLine();

                        Console.WriteLine("Enter an author: ");
                        string author = Console.ReadLine();

                        Console.WriteLine("Enter a genre: ");
                        string genre = Console.ReadLine();

                        BookMethods.BookAdd(books, title, author, genre);
                        break;
                    case "6":
                        BookMethods.ListBooks(books);
                        break;
                    case "7":
                        continuing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
                if (continuing)
                {
                    Console.WriteLine("Would you like to continue?(y/n)");
                    continuing = Console.ReadLine() == "y" ? true : false;
                }
            } while (continuing);

            Console.WriteLine("Goodbye!");
            SavedBooks.SaveBooks(books);
        }
    }
}