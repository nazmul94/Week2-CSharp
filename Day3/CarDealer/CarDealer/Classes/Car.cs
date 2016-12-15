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
        public override void SellVehicle(string make, bool isSold, int price)
        {
            this.IsSold = isSold;
            if (isSold)
            {
                vehicleStock--;
                this.TotalSold += price;
                Console.WriteLine("The {0} (car) has been successfully sold for £{1}", make, price);
            }
        }

        public override string ToString()
        {
            string retVal = "\tThe " + Make + " " + Model + " has a mileage of " + Mileage + " and has a price of £" + Price + ".\n";
            if (NumberOfDoors != 0)
            {
                retVal += "\tIt has an engine size of " + EngineSize + "L and contains " + NumberOfDoors + " doors.\n";
            }
            return retVal;
        }
    }
}
