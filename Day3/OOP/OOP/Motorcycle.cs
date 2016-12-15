using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Motorcycle : Vehicle
    {
        //fields and properties
        public Boolean HasStand { get; set; }
        public static int numberOfBikes;

        //constructor
        public Motorcycle(string make, string model, double engineSize, int price, int mileage, int speed, bool hasStand) 
            : base(make, model, engineSize, price, mileage, speed)
        {
            this.HasStand = hasStand;
        }

        //methods
        public void addBike(int numBikes)
        {
            numberOfBikes+= numBikes;
            numberOfVehicles += numBikes;
        }

        public void soldCar(int numCar)
        {
            numberOfBikes -= numCar;
            numberOfVehicles -= numCar;
        }
    }
}
