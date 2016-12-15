using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicCarDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();
            Car car1 = new Car("Volkswagon", "Golf", 10000);
            carList.Add(car1);

            Console.WriteLine("You are going to enter the details of a car");

            Boolean youWantToContinue = true;

            while (youWantToContinue)
            {
                Console.WriteLine("What would you like to do?\n\tAdd a car (A)\n\tList cars (L) \n\tQuit (Q)");
                char decision = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (decision)
                {
                    case 'A':
                        //Make
                        Console.WriteLine("What is the make?");
                        Car car2 = new Car();
                        car2.Make = Console.ReadLine();

                        //Model
                        Console.WriteLine("What is the model?");
                        car2.Model = Console.ReadLine();

                        //Price
                        Console.WriteLine("What is its price?");
                        car2.Price = Convert.ToInt32(Console.ReadLine());
                        carList.Add(car2);
                        break;

                    case 'L':
                        foreach (Car c in carList)
                        {
                            Console.WriteLine(c.ToString());
                        }
                        break;

                    case 'Q':
                        Console.WriteLine("Thank you, goodbye!");
                        youWantToContinue = false;
                        break;

                    default:
                        Console.WriteLine("Not Valid!");
                        break;
                }
            }
        }
    }
}
