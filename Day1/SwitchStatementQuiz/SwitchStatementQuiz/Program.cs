using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatementQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favourite sport?");
            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "football":
                case "rugby":
                    Console.WriteLine("Typical...");
                    break;
                case "tennis":
                case "table tennis":
                    Console.WriteLine("That's great");
                    break;
                case "hockey":
                    Console.WriteLine("Hockey is awesome");
                    break;
                default:
                    Console.WriteLine("Sorry, not familiar with that sport.");
                    break;
            }
        }
    }
}
