using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Vehicle
    {
        //fields & properties
        public string Make { get; set; }
        public string Model { get; set; }
        public double EngineSize { get; set; }
        public int Price { get; set; }
        public int Speed { get; set; }
        private int mileage;
        public int Mileage
        {
            get
            {
                return mileage;
            }

            set
            {
                if (value > 0)
                    mileage = value;
            }
        }
        protected static int numberOfVehicles = 200;

        //constructor
        public Vehicle() { }

        public Vehicle(string make, string model, double engineSize, int price, int mileage, int speed)
        {
            this.Make = make;
            this.Model = model;
            this.EngineSize = engineSize;
            this.Price = price;
            this.mileage = mileage;
            this.Speed = speed;
        }


        //methods
        public void Accelerate(int increment)
        {
            Speed += increment;
        }

        public void Decelerate(int decrement)
        {
            Speed -= decrement;
        }

        public void SoldVehicle()
        {
            numberOfVehicles--;
        }

        public void SoldVehicles(int numSold)
        {
            numberOfVehicles = numberOfVehicles - numSold;
        }

    }
}
