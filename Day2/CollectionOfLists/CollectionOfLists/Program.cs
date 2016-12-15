using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> bookList = new List<string>() { "the elegent universe", "a brief history in time", "relativity" };

            Console.WriteLine("Welcome to Nazmul's library of books. Here is a list of my books:");
            bookList.ForEach(Console.WriteLine);

            char action = 'a';

            while (action != 'Q')
            {
                Console.WriteLine(" \nWhat would you like to do? (Add ='A', Delete='D', View='V', Sort='S', Search='G', Quit='Q')\n");
                try
                {
                    action = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                switch (action)
                {
                    case 'A':
                        Console.WriteLine("What book do you want to add?");
                        string bookToAdd = Console.ReadLine().ToLower();
                        bookList.Add(bookToAdd);
                        Console.WriteLine("You have successfully added " + bookToAdd + " to the list\n");
                        break;

                    case 'D':
                        Console.WriteLine("Which book do you want to remove from the list?");
                        string bookToDelete = Console.ReadLine().ToLower();
                        bool doesContainD = bookList.Contains(bookToDelete);
                        if (doesContainD)
                        {

                            bookList.Remove(bookToDelete);
                            Console.WriteLine("You have successfully removed " + bookToDelete + " from the list\n");
                        }
                        else
                        {
                            Console.WriteLine("Error: cannot delete a book which does not exist inside the list.");
                        }                      
                        break;

                    case 'V':
                        Console.WriteLine("Here is a list of Nazmul's books: ");
                        bookList.ForEach(Console.WriteLine);
                        break;

                    case 'S':
                        bookList.Sort();
                        Console.WriteLine("The book list has been successfully sorted\n");
                        break;

                    case 'Q':
                        Console.WriteLine("Thank you for visiting Nazmul's booklist\nGoodbye!");
                        break;

                    case 'G':
                        Console.WriteLine("What book would you like to search?");
                        string bookToSearch = Console.ReadLine().ToLower();
                        bool doesContainS = bookList.Contains(bookToSearch);
                        if (doesContainS)
                        {
                            Console.WriteLine("Nazmul's book list does contain " + bookToSearch + "!\n");
                        }
                        else
                        {
                            Console.WriteLine("Unfortunately Nazmul's booklist does not contain " + bookToSearch+ ". We will definitely consider adding it!\n");
                        }
                        break;

                    default:
                        Console.WriteLine("Sorry, please provide a valid action");
                        break;
                }
            }
        }
    }
}
