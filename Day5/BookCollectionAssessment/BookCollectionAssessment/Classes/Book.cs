using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollectionAssessment.Classes
{
    public class Book
    {
        //Fields and Properties of the Book object
        public string Title { get; set; }
        public string Author { get; set; }
        private float price;
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value > 0.00F)
                {
                    price = value;
                }
            }
        }

        //constructor without initialised values
        public Book() { }

        //constructor to create book object with initialised values
        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
            this.Price = 0.0F;
            //Increase the stock by one as soon as book is created
            Inventory.numberOfBooks++;
            //Add the newly constructed book to booklist
            Inventory.bookList.Add(this);
            //Inform user of the addition
            Console.WriteLine(this.Title + " has been added to the booklist");
        }

        public Book(string title, string author, float price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
            //Increase the stock by one as soon as book is created
            Inventory.numberOfBooks++;
            //Add the newly constructed book to booklist
            Inventory.bookList.Add(this);
            //Inform user of the addition
            Console.WriteLine(this.Title + " has been added to the booklist");
        }

        //Methods (Functions)
        public virtual string PrintBookDetail()
        {
            string retVal = this.Title + " was authored by " + this.Author + ".";
            if(Price > 0.00F)
            {
                retVal += "\n\tIt has a price of £" + this.Price;
            }

            return retVal;
        }
    }
}
