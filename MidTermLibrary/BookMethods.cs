using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MidTermLibrary
{
    
    class BookMethods 
    {
        //Data Members -andre
        
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


        public static void BookDue(Book book)
         {
            if (book.CheckedIn)
            {
                book.CheckedIn = false;
                book.DueDate = DateTime.Now.AddDays(14);
            }
            else
            {
                book.CheckedIn = true;
                book.DueDate = DateTime.Now;
            }
         }
 
        public static void BookAdd(List<Book> books, string inputTitle, string inputAuthor, string inputGenre)
        {
            Book book = new Book(inputTitle, inputAuthor, inputGenre);

            books.Add(book);

        }
        //
  
        // a method bookvalidation -andre
         
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

        // - tony
        public static void Display(Book book)
        {
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Genre: {book.Genre}");
            Console.WriteLine($"Status: {(book.CheckedIn ? "On shelves": "Out until "+book.DueDate.ToString("MM/dd/yyyy"))}");
            Console.WriteLine("-------");
            
        }

        public static void ListBooks(List<Book> books)
        {//Luke
            foreach (Book book in books)
            {
                Console.WriteLine($"{books.IndexOf(book)+1}. {book.Title} - {(book.CheckedIn ? "On Shelf":"Checked Out")}");
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        public static bool IsMatch(string input, string target)
        {//Search by title keyword
            string[] wanted = target.ToLower().Split(' ');
            string regexOfTarget = "";

            foreach (string word in wanted)
            {
                
                regexOfTarget = regexOfTarget+$@"\b({word})\b|";
            }
            //This is a bit of a mess but it works well enough -Luke
            return Regex.IsMatch(input.ToLower(), $@"\b(\w*({regexOfTarget}!)\w*)\b");
        }

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

        // -tony
        public static void DisplaySpecific(List<Book> books, string search, string input)
        {
            switch (search)
            {
                case "Title": foreach(Book book in books)
                    {
                        if(IsMatch(input, book.Title))
                        {
                            Console.WriteLine($"#{books.IndexOf(book)+1}");
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
            string response = Console.ReadLine();
            if(int.TryParse(response, out index))
            {
                Console.WriteLine(GetSynopsis(index-1));
                Console.WriteLine("\nPress enter to return to the main menu.");
                Console.ReadKey();
            }
        }
    }
}
