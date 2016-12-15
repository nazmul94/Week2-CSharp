using BookCollectionAssessment.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollectionAssessment
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================");

            foreach (Book book in Inventory.bookList)
            {
                Console.WriteLine(book.PrintBookDetail());
            }

            Console.WriteLine("=======================================");
            Console.WriteLine("There's " + (Inventory.bookList.Count) + " books in the list");
            Console.WriteLine("=======================================");

            //Do while loop to continuously interact with user
            
            Execute executable = new Execute();
        }
    }
}
