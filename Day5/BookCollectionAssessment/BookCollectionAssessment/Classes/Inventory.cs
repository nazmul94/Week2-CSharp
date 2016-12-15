using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollectionAssessment.Classes
{
    public class Inventory
    {
        public static List<Book> bookList = new List<Book>();
        static public int numberOfBooks = 0;

        public static NonFiction elegantUniverse = new NonFiction("The Elegant Universe", "Brian Greene", 11.38F, 009928992, "Science", "Vintage");
        public static ScientificJournal einstein = new ScientificJournal("The Principia: Mathematical Principles of Natural Philosophy", "Isaac Newton", 15, new DateTime(1687, 07, 5), "Cambridge University Press");
        public static Novel fables = new Novel("Aesop's Fables", "Aesop", 6.99F, 90446494, "fantasy", "Penguin");
  
    }
}
