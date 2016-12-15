using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollectionAssessment.Classes
{
    public class Execute
    {
        //Field that controls the looping mech
        public bool youWantToContinue = true;

        //Executable code
        public Execute()
        {
            do
            {
                Console.WriteLine("What would you like to do?\n\tAdd a book? (ADD)\n\tView the book list? (VIEW), Quit? (QUIT)");

                string action = Console.ReadLine().ToUpper();

                switch (action)
                {
                    //What is the course of action to take place
                    case "AD":
                    case "ADD":
                        Console.WriteLine("What is the type of book you would like to add? Currently we only accept Novels, Scientific Journals and non-fictional books");
                        string bookType = Console.ReadLine().ToUpper();

                        switch (bookType)
                        {
                            case "NOVEL":
                            case "NOVELS":
                                Novel novel1 = new Novel();

                                Console.WriteLine("What is the name of your novel?");
                                novel1.Title = Console.ReadLine();

                                Console.WriteLine("Who is the author of your novel?");
                                novel1.Author = Console.ReadLine();

                                Console.WriteLine("What is the ISBN of your novel?");
                                novel1.ISBN = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Do you want to enter the price, genre and publisher of your novel? (Y/N)");
                                char extraDetail = Convert.ToChar(Console.ReadLine().ToUpper());

                                switch (extraDetail)
                                {
                                    case 'Y':
                                        Console.WriteLine("Sorry I dont have enough time");
                                        break;
                                    case 'N':
                                        Console.WriteLine("Thanks for adding your book to my book list!");
                                        break;
                                }

                                Inventory.bookList.Add(novel1);
                                break;

                            case "SCIENTIFIC":
                            case "SCIENTIFIC JOURNAL":
                                ScientificJournal sci = new ScientificJournal();

                                Console.WriteLine("What is the name of your Scientific Journal?");
                                sci.Title = Console.ReadLine();

                                Console.WriteLine("Who is the author of your novel?");
                                sci.Author = Console.ReadLine();

                                //Get Release date from user
                                Console.WriteLine("What Year was the Scientific Journal released? (Please enter in the date in the following format: yyyy)");
                                int year = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("What Month was the Scientific Journal released? (Please enter in the date in the following format: mm)");
                                int month = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("What Day was the Scientific Journal released? (Please enter in the date in the following format: dd)");
                                int day = Convert.ToInt32(Console.ReadLine());
                                //Assign release date to the object
                                sci.ReleaseDate = new DateTime(year, month, day);

                                //Get research centre
                                Console.WriteLine("Which research centre was the research conducted in?");
                                string centre = Console.ReadLine();

                                sci.ResearchCentre = centre;

                                Console.WriteLine("Do you want to enter the price of your scientific journal? (Y/N)");
                                char extraDetailSci = Convert.ToChar(Console.ReadLine().ToUpper());

                                switch (extraDetailSci)
                                {
                                    case 'Y':
                                        Console.WriteLine("Sorry I dont have enough time");
                                        break;
                                    case 'N':
                                        Console.WriteLine("Thanks for adding your book to my book list!");
                                        break;
                                }
                                //Add journal to list
                                Inventory.bookList.Add(sci);
                                break;

                            case "NONFICTION":
                            case "NON_FICTION":
                            case "NON-FICTION":

                                //create a non-fiction object
                                NonFiction nonfic = new NonFiction();

                                //Get User input for the details of the book
                                Console.WriteLine("What is the name of your Non-fictional book?");
                                nonfic.Title = Console.ReadLine();

                                Console.WriteLine("Who is the author of your Non-fictional book?");
                                nonfic.Author = Console.ReadLine();

                                Console.WriteLine("What is the ISBN of your Non-fictional book?");
                                nonfic.ISBN = Convert.ToInt32(Console.ReadLine());

                                //Is extra detail input needed?
                                Console.WriteLine("Do you want to enter the price, genre and publisher of your Non-fictional book? (Y/N)");
                                char extraDetailNon = Convert.ToChar(Console.ReadLine().ToUpper());

                                //If extra detail input is required, acquire the detail
                                switch (extraDetailNon)
                                {
                                    case 'Y':
                                        Console.WriteLine("Sorry I dont have enough time");
                                        break;
                                    case 'N':
                                        Console.WriteLine("Thanks for adding your book to my book list!");
                                        break;
                                }

                                Inventory.bookList.Add(nonfic);
                                break;
                        }
                        break;

                    case "VIEW":
                        Console.WriteLine("\n");
                        foreach (Book book in Inventory.bookList)
                        {
                            Console.WriteLine(book.PrintBookDetail());
                        }
                        Console.WriteLine("\n");
                        break;

                    case "QUIT":
                        youWantToContinue = false;
                        Console.WriteLine("\nThank you for visiting my booklist, goodbye!");
                        break;

                    default:
                        Console.WriteLine("Not valid");
                        break;
                }
            } while (youWantToContinue);
        }
    }
}
