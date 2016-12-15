using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 20;
            int chances = 0;
            int guess = 0;
            
            Console.WriteLine("Guess my number!");

            while (guess != myNumber && chances < 3)
            {
                guess = Convert.ToInt16(Console.ReadLine());

                if (guess == myNumber)
                {
                    Console.WriteLine("Congratulations! You have guessed my number");
                }
                else if (guess < myNumber)
                {
                    Console.WriteLine("Sorry, that's not my number. Try a bigger number.");
                    chances++;
                }
                else if (guess > myNumber)
                {
                    Console.WriteLine("Sorry, that's not my number. Try a smaller number");
                    chances++;
                }
            }

                if (chances == 3)
            {
                Console.WriteLine("Unlucky buddy, you ran out of chances");
            }
        }
    }
}
