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
            Vehicle boat = new Vehicle("a boat", "richkid", 500000, 10);
            Car astra = new Car("Vauxhall", "Astra", 10000, 20000, 3, 1.8);
            Car ds9 = new Car("aston martin", "db9", 80000, 30000, 5, 3.5);
            Car m5 = new Car("bmw", "m5", 29500, 10000, 5, 2.5);
            Car prius = new Car("toyota", "prius", 24000, 50000, 5, 2.0);

            Console.WriteLine("=======");

            //foreach (Vehicle vehicle in VehicleCatalogue)
            //{
            //    Console.WriteLine("make + model: {0} {1}", vehicle.Make, vehicle.Model);
            //}

            astra.SellVehicle("astra",true, 1000);

            Console.WriteLine("=======");

            Console.WriteLine("The Vehicle catalogue contains the following:\n");
            foreach (Vehicle vehicle in VehicleCatalogue)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }
    }
}

