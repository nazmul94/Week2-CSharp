using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Classes
{
    class Car : Vehicle
    {
        //Fields & Properties
        public int NumberOfDoors { get; set; }
        public double EngineSize { get; set; }

        //Constructors
        public Car(string make, string model, int price, int mileage)
            : base(make, model, price, mileage)
        {
            this.TypeOfVehicle = "car";
        }

        public Car(string make, string model, int price, int mileage, int numberOfDoors, double engineSize)
            : base(make, model, price, mileage)
        {
            this.TypeOfVehicle = "car";
            this.NumberOfDoors = numberOfDoors;
            this.EngineSize = engineSize;
        }

        //Methods
        //bs method get rid of this
        public override string ToString()
        {
            string retVal = "\tThe " + Make + " " + Model + " has a mileage of " + Mileage + " and has a price of £" + Price + ".\n";
            if (NumberOfDoors != 0)
            {
                retVal += "\tIt has an engine size of " + EngineSize + "L and contains " + NumberOfDoors + " doors.\n";
            }
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
                Console.WriteLine("The {0} {1} (car) has been successfully sold for £{2}.\n\tThe total profit made this year is £{3}", this.Make, this.Model, this.Price, Vehicle.TotalSold);
            }
            else
                Console.WriteLine("Not found");
        }
    }
}
