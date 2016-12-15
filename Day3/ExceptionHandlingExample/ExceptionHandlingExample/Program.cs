using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 1 to 10");
            
            while(true)
            {
                try
                {
                    int userInput = int.Parse(Console.ReadLine());
                    if(userInput < 1 || userInput > 10)
                    {
                        throw new Exception("Number must be between 1 and 10");
                    }
                    Console.WriteLine("Your number is: {0}", userInput);
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Not an int! Please try again");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Not a valid int! Upper limit is 4 billion");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Thank you for playing!");
                }
            }
        }
    }
}