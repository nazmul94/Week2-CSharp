using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollectionAssessment.Classes
{
    public class NonFiction : Book
    {
        //Fields & Properties of the Novels subclass
        public int ISBN { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }

        //Constructors
        public NonFiction() { }

        public NonFiction(string title, string author, int isbn)
            : base(title, author)
        {
            this.ISBN = isbn;
        }

        public NonFiction(string title, string author, float price, int isbn, string genre, string publisher)
            : base(title, author, price)
        {
            this.ISBN = isbn;
            this.Genre = genre;
            this.Publisher = publisher;
        }

        //Methods (Functions)

            //Method to print out a String of Book Details (Use console.writeline!)
        public override string PrintBookDetail()
        {
            string retVal = this.Title + " was authored by " + this.Author + ".";

            if (Price != 0.0F)
            {
                retVal += "\n\tIt has a price of £" + this.Price;
            }

            retVal += "\n\tIt has an ISBN of: " + ISBN;

            return retVal;
        }
    }
}
