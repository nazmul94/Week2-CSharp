using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollectionAssessment.Classes
{
    public class ScientificJournal : Book
    {
        //Fields & Properties
        public DateTime ReleaseDate { get; set; }
        public string ResearchCentre{ get; set; }

        //Constrcutors
        public ScientificJournal() { }

        public ScientificJournal(string title, string author, DateTime releaseDate)
            : base(title, author)
        {
            this.ReleaseDate = releaseDate;
        }

        public ScientificJournal(string title, string author, int price, DateTime releaseDate, string researchCentre)
            :base(title, author, price)
        {
            this.ReleaseDate = ReleaseDate;
            this.ResearchCentre = researchCentre;
            this.Price = price;
        }


        //Methods (Functions)

        //Method to print out a String of Book Details (Use console.writeline!)
        public override string PrintBookDetail()
        {
            string retVal = this.Title + " was authored by " + this.Author + ".";

            if (Price != 0.0)
            {
                retVal += "\n\tIt has a price of £" + this.Price;
            }

            if (ResearchCentre != "")
            {
                retVal += "\n\tThe research was conducted at " + this.ResearchCentre;
            }
            retVal += "\n\tIt was published on " + this.ReleaseDate;

            return retVal;
        }
    }
}
