using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEncapsulationExercise.Classes
{
    public class Account
    {
        public static decimal balance = 0;

        public static decimal AccountTransaction(Meal meal)
        {
            balance += meal.price;
            balance -= meal.cost;

            return balance;
        }
    }
}
