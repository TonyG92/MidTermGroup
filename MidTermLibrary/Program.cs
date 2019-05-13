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
            //This first block here is us creating our main book list and its grabbing it from the savedbook function.
            List<Book> books = SavedBooks.FindBooks();
<<<<<<< HEAD

            string response = "y";

=======
            // we used a bool to keep the program running as long as the user wishes
>>>>>>> 708c3f49684ae2792f81ee930c374931b13f6276
            bool continuing = true;

            string choice = "";
            Console.WriteLine("Welcome to four codemen library!");
            //the "Do While" Loop is tracking userinput against cases that we've structured to give out responses according to the users wishes.
            // The reason we choose a do while was so that the program would cycle through itself at least once.
            // after we get our first input from the user the program breaks it down to different options after that using the case statements to...
            // call on different methods for the desired user path. 
            do
            {
                Console.Clear();
                // this is our user prompt and our open screen.
                Console.WriteLine("1. Search by author" +
                    "\n2. Search by title keyword" +
                    "\n3. Search by genre" +
                    "\n4. Checkout a book, or turn one in" +
                    "\n5. Add a new book" +
                    "\n6. Display all titles with index" +
                    "\n7. Display all books and information" +
                    "\n8. Exit");
                choice = Console.ReadLine().ToLower();
                switch (choice)
                {
<<<<<<< HEAD


=======
                    // checking out and adding new books
>>>>>>> 708c3f49684ae2792f81ee930c374931b13f6276
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
                        Console.WriteLine("What book would you like to checkout/turn in?? ");

                        BookMethods.BookDue(books.ElementAt(int.Parse(Console.ReadLine()) - 1));
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
                        BookMethods.DisplaySpecific(books, "All", "");
                        break;

                    case "8":
                        continuing = false;

                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (continuing);

            Console.WriteLine("Goodbye!");
            SavedBooks.SaveBooks(books);
        }
    }
}
