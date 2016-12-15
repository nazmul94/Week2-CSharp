using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    //class -> reference type, struct -> value type
    public struct Book
    {
        public string title;
        public string category;
        public string author;
        public int numPages;
        public int currentPage;
        public string ISBN;
        public int price;

        //constructor is a method to instantiate fields (Attributes)
        public Book(string title, string category, string author, int numPages, int currentPage, string ISBN, int price)
        {
            this.title = title;
            this.category = category;
            this.author = author;
            this.numPages = numPages;
            if(currentPage <= numPages)
            {
                this.currentPage = currentPage;
            }
            else
            {
                throw new Exception("Not acceptable!");
            }
            this.ISBN = ISBN;
            this.price = price;
        }

        //method nextPage
        public void nextPage()
        {
            if(currentPage != numPages)
            {
                currentPage++;
                Console.WriteLine("current page is now {0}", this.currentPage);
            }
            else
            {
                Console.WriteLine("You have reached the end of the book");
            }
        }

        //method previous page
        public void prevPage()
        {
            if(currentPage != 1)
            {
                currentPage--;
                Console.WriteLine("current page is now {0}", this.currentPage);
            }
            else
            {
                Console.WriteLine("You are at the beginning of the book");
            }
        }
    }
}
