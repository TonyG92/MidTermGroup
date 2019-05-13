using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLibrary
{
    class Book
    {

        //Data Membeers (Fields)
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
        //There are multiple constructors here to save time instead of making it more complicated later on.
        //These are used for 3 different instances

        //Firstly, used for newly added books - in book methods
        public Book(string _title, string _author, string _genre)
        {
            title = _title;
            author = _author;
            genre = _genre;
            checkedin = true;
        }


        //Secondly, Added the duedate to persist with the data. Added this to make it work for saved books. -in saved books class
        public Book(string _title, string _author, string _genre, bool _checkedIn)
        {
            title = _title;
            author = _author;
            genre = _genre;
            checkedin = _checkedIn;
            duedate = DateTime.Now;
        }

        //Thirdly, This is for saving the info after you check out the books. in saved books class
        public Book(string _title, string _author, string _genre, bool _checkedIn, DateTime _dueDate)
        {
            title = _title;
            author = _author;
            genre = _genre;
            checkedin = _checkedIn;
            duedate = _dueDate;
        }
    }
}
