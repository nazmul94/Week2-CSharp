using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    class Car : Vehicle
    {
        //fields & properties
        public int NumOfDoors { get; set; }
        public static int numberOfCars;

        //constructors
        public Car() { }

        public Car(string make, string model, double engineSize, int price, int mileage, int speed, int numOfDoors)
            : base (make, model, engineSize, price, mileage, speed)
        {
            this.NumOfDoors = numOfDoors;
        }

        //methods
        public void addCar(int numCar)
        {
            numberOfCars += numCar;
            numberOfVehicles += numCar;
        }

        public void soldCar(int numCar)
        {
            numberOfCars -= numCar;
            numberOfVehicles -= numCar;
        }
    }
}
