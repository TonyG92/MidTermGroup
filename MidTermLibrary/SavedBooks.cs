using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLibrary
{
    class SavedBooks
    {
        public static string GetBookFile()
        {
            string test;
            try
            {
                test = System.IO.File.ReadAllText($@"{System.IO.Directory.GetCurrentDirectory()}\booklist.txt");
                return $@"{System.IO.Directory.GetCurrentDirectory()}\booklist.txt";
            }//i barely know why this works but it does -Luke
            catch (Exception e)
            {
                return $@"..\..\booklist.txt";
            }
        }
        public static List<Book> FindBooks()
        {
            // making new book variable
            List<Book> books = new List<Book>();
            //new pulls in file and reads each line in the txt file as a index
            string[] lines = System.IO.File.ReadAllLines(GetBookFile());

            //for each line we are now calling it a book. we are now splitting them at each "/"
            foreach (string book in lines)
            {
                //splits each line at "/" going down
                string[] info = book.Split('/');
                //makes new book ( go to Book)
                //and follows pattern of title author genre
                Book toAdd = new Book(info[0], info[1], info[2], bool.Parse(info[3]));
                //adds to new list
                books.Add(toAdd);
            }
            return books;
        }

        public static void SaveBooks(List<Book> books)
        {
            System.IO.File.WriteAllText(GetBookFile(), "");//clears the current file
            List<string> lines = new List<string>();

            foreach (Book book in books)
            {
                string newBook = $"{book.Title}/{book.Author}/{book.Author}/{book.CheckedIn}";
                lines.Add(newBook);
            }//gets all the lines to put in

            string[] allLines = lines.ToArray();
            System.IO.File.WriteAllLines(GetBookFile(), allLines);//writes the lines by object in string array
        }//i wish it wasnt so difficult :agony: -Luke
    }
}