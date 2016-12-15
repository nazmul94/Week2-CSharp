using CarDealer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    class Program
    {
        public static List<Vehicle> VehicleCatalogue = new List<Vehicle>();
        public static List<Vehicle> SoldVehicle = new List<Vehicle>();

        static void Main(string[] args)
        {
            Vehicle boat = new Vehicle("luxBoat", "grandier", 500000, 10);
            Car astra = new Car("Vauxhall", "Astra", 10000, 20000, 3, 1.8);
            Car ds9 = new Car("aston martin", "db9", 80000, 30000, 5, 3.5);
            Car m5 = new Car("bmw", "m5", 29500, 10000, 5, 2.5);
            Motorcycle fg200 = new Motorcycle("yamaha", "fg200", 3500, 12000);
            Motorcycle cb350 = new Motorcycle("honda", "cb350", 2000, 23500);

            Console.WriteLine("=============================================================================");

            astra.SellVehicle("astra",true);
            boat.SellVehicle("luxBoat", true);
            fg200.SellVehicle("fg200", true);

            Console.WriteLine("=============================================================================");

            Console.WriteLine("The Vehicle catalogue contains the following:\n");
            foreach (Vehicle vehicle in VehicleCatalogue)
            {
                Console.WriteLine(vehicle.ToString());
            }

            Console.WriteLine("=============================================================================");

            Console.WriteLine("The sold vehicle list now contains:\n");
            foreach (Vehicle vehicle in SoldVehicle)
            {
                Console.WriteLine(vehicle.SoldInfo());
            }
        }
    }
}

