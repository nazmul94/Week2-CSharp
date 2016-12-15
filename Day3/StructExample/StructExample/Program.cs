using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("Harry Potter", "Fantasy", "J. K. Rowling", 224, 15, "1408855895", 8);
            Console.WriteLine(myBook.currentPage);
            myBook.nextPage();
            Console.WriteLine(myBook.currentPage);
            myBook.prevPage();
            Console.WriteLine(myBook.currentPage);
            Console.WriteLine(myBook.title);
        }
    }
}
