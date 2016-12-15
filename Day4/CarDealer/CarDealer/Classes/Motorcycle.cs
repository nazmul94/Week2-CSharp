using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Classes
{
    class Motorcycle : Vehicle
    {
        //Fields & Properties
        public int EngineSize { get; set; }

        //Constructors
        public Motorcycle(string make, string model, int price, int mileage)
            : base (make, model, price, mileage)
        { }

        public Motorcycle(string make, string model, int price, int engineSize, int mileage)
            :base (make, model, price, mileage)
        {
            this.EngineSize = engineSize;
        }

        //Methods
        public override string ToString()
        {
            string retVal = "\tThe " + Make + " " + Model + " has a mileage of " + Mileage + " and has a price of £" + Price + ".\n";
            return retVal;
        }

        public override void SellVehicle(string make, bool isSold)
        {
            this.IsSold = isSold;
            if (isSold && Program.VehicleCatalogue.Contains(this))
            {
                vehicleStock--;
                Program.VehicleCatalogue.Remove(this);
                Program.SoldVehicle.Add(this);
                Vehicle.TotalSold += this.Price;
                Console.WriteLine("The {0} {1} (motorbike) has been successfully sold for £{2}.\n\tThe total profit made this year is £{3}", this.Make, this.Model, this.Price, Vehicle.TotalSold);
            }
            else
                Console.WriteLine("Not found");
        }
    }
}
