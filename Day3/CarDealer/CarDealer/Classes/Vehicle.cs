using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Classes
{
    public class Vehicle
    {
        //Fields & Properties
        public string TypeOfVehicle { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public Boolean IsSold { get; set; }
        public int TotalSold = 0;
        private int mileage { get; set; }
        public int Mileage
        {
            get
            {
                return mileage;
            }
            set
            {
                if(value >= 0)
                {
                    mileage = value;
                }
            }
        }



        //public static List<Vehicle> VehicleCatalogue = new List<Vehicle>();
        public static int vehicleStock = 0;

        //Constructors
        public Vehicle() { Console.WriteLine("A non-identified Vehicle has been added"); }

        public Vehicle(string make, string model, int price, int mileage)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Mileage = mileage;
            this.IsSold = false;

            vehicleStock++;
            Program.VehicleCatalogue.Add(this);
            Console.WriteLine("The vehicle {0} {1} has been successfully added to the catalogue \n\tVehicle stock is now {2}", make, model, Vehicle.vehicleStock);
        }

        //Methods
        public override string ToString()
        {
            string retVal = "\tThe " + Make + " " + Model + " has a mileage of " + Mileage+ " and has a price of £" + Price + ".\n";
            return retVal;
        }

        public virtual void SellVehicle(string make, bool isSold, int price)
        {
            this.IsSold = isSold;
            if (isSold && Program.VehicleCatalogue.Contains(this))
            {
                vehicleStock--;
                Program.VehicleCatalogue.Remove(this);
                Program.SoldVehicle.Add(this);
                this.TotalSold += price;
                Console.WriteLine("A vehicle ({0} {1}) has been successfully sold for £{2}", this.Make, this.Model, price);
            }
            else
                Console.WriteLine("Not found");
        }
    }
}
