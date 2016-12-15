using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollectionAssessment.Classes
{
    public class Novel : Book
    {
        //Fields & Properties of the Novels subclass
        public int ISBN { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }

        //Constructors
        public Novel() { }

        public Novel(string title, string author, int isbn)
            : base(title, author)
        {
            this.ISBN = isbn;
        }

        public Novel(string title, string author, float price, int isbn, string genre, string publisher)
            : base(title, author, price)
        {
            this.ISBN = isbn;
            this.Publisher = publisher;
            this.Genre = genre;
        }

        //Methods (Functions)

            //Method to print out a String of Book Details (Use console.writeline!)
        public override string PrintBookDetail()
        {
            string retVal = this.Title + " was authored by " + this.Author + ".";
            retVal += "\n\tIts genre is " + this.Genre;
            if (Price != 0.0F)
            {
                retVal += "\n\tIt has a price of £" + this.Price;
            }

            retVal += "\n\tIt has an ISBN of: " + ISBN;

            return retVal;
        }
    }
}
