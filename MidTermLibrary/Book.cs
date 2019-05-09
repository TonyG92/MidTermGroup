using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLibrary
{
    class Book
    {

        //Data Members
        private string title;
        private string author;
        private string genre;
        private bool checkedin;
        private DateTime duedate;

        //Properties
        public string Title
        {
            set { title = value; }
            get { return title; }
        }

        public string Author
        {
            set { author = value; }
            get { return author; }
        }

        public string Genre
        {
            set { genre = value; }
            get { return genre; }
        }

        public bool CheckedIn
        {
            set { checkedin = value; }
            get { return checkedin; }
        }
        
        public DateTime DueDate
        {
            set { duedate = value; }
            get { return duedate; }
        }

        //Constructor 

            //from Program to here ; splits it into titile author and genre
        public Book(string _title, string _author, string _genre)
        {
            title = _title;
            author = _author;
            genre = _genre;
        }

        

    }
}
