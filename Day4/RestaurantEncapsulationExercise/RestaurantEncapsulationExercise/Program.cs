using RestaurantEncapsulationExercise.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 0;

            //add some meals data
            Meal steak = new Meal();
            steak.addMeal("steak", 20.00M, 5.00M);

            Meal fajitas = new Meal();
            fajitas.addMeal("fajitas", 12.00M, 2.00M);

            Meal pumpkinRisotto = new Meal();
            pumpkinRisotto.addMeal("pumpkinRisotto", 10.00M, 1.00M);

            Order order1 = new Order();
            order1.takeOrder(steak);
            balance = Account.AccountTransaction(steak);

            Order order2 = new Order();
            order2.takeOrder(pumpkinRisotto);
            balance = Account.AccountTransaction(pumpkinRisotto);

            Console.WriteLine("Tonight in the restaurant, we made £{0:N2}.", balance);

        }
    }
}

