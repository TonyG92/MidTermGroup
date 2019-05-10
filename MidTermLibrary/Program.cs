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
            Console.WriteLine("Welcome to four codemen library! Enter y to continue.");
            response = Console.ReadLine();

            

            do
            {
                Console.Clear();
<<<<<<< HEAD

                Console.WriteLine("Please select either Author, Title , Genre or type All to get a list of all our books.");

                Console.WriteLine("Please select Author, Title or Genre.\nType All to get a list of all our books.");

=======
                Console.WriteLine("1. Search by author" +
                    "\n2. Search by title keyword" +
                    "\n3. Search by genre" +
                    "\n4. Checkout a book" +
                    "\n5. Add a new book" +
<<<<<<< HEAD
                    "\n6. Display all titles with index");
>>>>>>> 98531866daf4ee9dc84fb1af42b02fe7efff1ceb
=======
                    "\n6. Display all titles with index" +
                    "\n7. Exit");
>>>>>>> 9a3998e9543cdfb75fba685913e3979665c6cfad
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
<<<<<<< HEAD
                        Console.WriteLine("What book do you want to check out");
                        BookMethods.BookDue(books.ElementAt(int.Parse(Console.ReadLine())+1));
=======
                        Console.WriteLine("What book would you like to checkout? ");

                        BookMethods.BookDue(books.ElementAt(int.Parse(Console.ReadLine()) + 1));
>>>>>>> 9a3998e9543cdfb75fba685913e3979665c6cfad
                        break;
                    case "5":
                        Console.WriteLine("What book would you like to add to the library?");
                        Console.WriteLine("Enter Title");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter Author");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter Genre");
                        string genre = Console.ReadLine();
                        break;
<<<<<<< HEAD
=======
                    case "6":
                        BookMethods.ListBooks(books);
                        break;
                    case "7":
                        continuing = false;
                        break;
>>>>>>> 98531866daf4ee9dc84fb1af42b02fe7efff1ceb
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
<<<<<<< HEAD
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
=======
                }
                if (continuing)
                {
                    Console.WriteLine("Would you like to continue?(y/n)");
                    continuing = Console.ReadLine() == "y" ? true : false;
                }
            } while (continuing);
>>>>>>> 9a3998e9543cdfb75fba685913e3979665c6cfad

            Console.WriteLine("Goodbye!");
            SavedBooks.SaveBooks(books);
        }
    }
}