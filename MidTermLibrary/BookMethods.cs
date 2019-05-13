using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace MidTermLibrary
{
<<<<<<< HEAD
    
    class BookMethods 
    {
        //Data Members/field -andre
        
        private string titlekeyword;
=======
    class BookMethods
    {
        //Data Members/field -andre
>>>>>>> 708c3f49684ae2792f81ee930c374931b13f6276

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

<<<<<<< HEAD
        
=======
>>>>>>> 708c3f49684ae2792f81ee930c374931b13f6276
        public static void BookDue(Book book)
        {
            if (book.CheckedIn)
<<<<<<< HEAD
                //if it is  alrady checked in, then book is there is to be checked out 
                //span of having the book is set to 14 days 
=======
            //if it is  alrady checked in, then book is there is to be checked out 
            //span of having the book is set to 14 days 
>>>>>>> 708c3f49684ae2792f81ee930c374931b13f6276
            {
                book.CheckedIn = false;
                book.DueDate = DateTime.Now.AddDays(14);
            }
            else
            {
                // if alrady checked out then this dignifies that you turn it in 
                //within the 14 days
                book.CheckedIn = true;
                book.DueDate = DateTime.Now;
            }
<<<<<<< HEAD
         }


=======
        }
>>>>>>> 708c3f49684ae2792f81ee930c374931b13f6276
        //takes in all info from the book(user input) and adds it to the list 
        public static void BookAdd(List<Book> books, string inputTitle, string inputAuthor, string inputGenre)
        {
            Book book = new Book(inputTitle, inputAuthor, inputGenre);
            books.Add(book);
        }
<<<<<<< HEAD
        
  
=======


>>>>>>> 708c3f49684ae2792f81ee930c374931b13f6276
        // a method bookvalidation based on title 
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
<<<<<<< HEAD

       //1 book
       // if booked is checked in  it will be on shelf, if not its out for 14 days
=======
        //1 book
        // if booked is checked in  it will be on shelf, if not its out for 14 days
>>>>>>> 708c3f49684ae2792f81ee930c374931b13f6276
        public static void Display(Book book)
        {
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Genre: {book.Genre}");
            //question mark is a mini of astaement , if book checked in if false it jumps to 
<<<<<<< HEAD
            Console.WriteLine($"Status: {(book.CheckedIn ? "On shelves": "Out until "+book.DueDate.ToString("MM/dd/yyyy"))}");
            Console.WriteLine("-------");
            
=======
            Console.WriteLine($"Status: {(book.CheckedIn ? "On shelves" : "Out until " + book.DueDate.ToString("MM/dd/yyyy"))}");
            Console.WriteLine("-------");

>>>>>>> 708c3f49684ae2792f81ee930c374931b13f6276
        }
        //displays title and if its checked out 
        public static void ListBooks(List<Book> books)
        {//Luke
            foreach (Book book in books)
            {
                Console.WriteLine($"{books.IndexOf(book) + 1}. {book.Title} - {(book.CheckedIn ? "On Shelf" : "Checked Out")}");
            }
        }
        // validates user input based on key words
        public static bool IsMatch(string input, string target)
        {
            string[] wanted = target.ToLower().Split(' ');
            string regexOfTarget = "";
            foreach (string word in wanted)
            {

                regexOfTarget = regexOfTarget + $@"\b({word})\b|";
            }
            //This is a bit of a mess but it works well enough -Luke
            return Regex.IsMatch(input.ToLower(), $@"\b(\w*({regexOfTarget}!)\w*)\b");
        }
        //gets the sumary of the book (syn)
        public static string GetSynopsis(int index)
        {
            string[] possible = SavedBooks.GetSynopsi();
            try
            {
                return possible[index];
            }
            catch (Exception)
            {
                return "Invalid book index.";
            }
        }
<<<<<<< HEAD

=======
>>>>>>> 708c3f49684ae2792f81ee930c374931b13f6276
        // search list for key words by title author and genre =- all displays all 
        public static void DisplaySpecific(List<Book> books, string search, string input)
        {
            switch (search)
            {
                case "Title":
                    foreach (Book book in books)
                    {
                        if (IsMatch(input, book.Title))
                        {
                            Console.WriteLine($"#{books.IndexOf(book) + 1}");
                            Display(book);
                        }
                    }
                    break;
                case "Author":
                    foreach (Book book in books)
                    {
                        if (IsMatch(input, book.Author))
                        {
                            Console.WriteLine($"#{books.IndexOf(book) + 1}");
                            Display(book);
                        }
                    }
                    break;
                case "Genre":
                    foreach (Book book in books)
                    {
                        if (IsMatch(input, book.Genre))
                        {
                            Console.WriteLine($"#{books.IndexOf(book) + 1}");
                            Display(book);
                        }
                    }
                    break;
                case "All":
                    foreach (Book book in books)
                    {
                        Console.WriteLine($"#{books.IndexOf(book) + 1}");
                        Display(book);
                    }
                    break;
            }
            Console.WriteLine("If you would like to view a books synopsis, enter its index." +
                "\nOtherwise, press enter to return to the main menu.");
            int index;
            string response = Console.ReadLine();  // return to synopsis or go to main menu;
<<<<<<< HEAD
            if(int.TryParse(response, out index))
=======
            if (int.TryParse(response, out index))
>>>>>>> 708c3f49684ae2792f81ee930c374931b13f6276
            {
                Console.WriteLine(GetSynopsis(index - 1));
                Console.WriteLine("\nPress enter to return to the main menu.");
                Console.ReadKey();
            }
        }
    }
}