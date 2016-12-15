using OOP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person naz = new Person();
            naz.Firstname = "Nazmul";
            naz.LastName = "Mumtahin";
            naz.BirthDate = new DateTime(1994, 09, 21);
            naz.sleep();
            naz.wakeUp();
            Console.WriteLine(naz.talk());

            Person david = new Person("David", "Beckam", new DateTime(1973, 1, 1));

            int result = naz.getAge();
            Console.WriteLine(result);

            Car tesla = new Car();
            tesla.Make = "Tesla";
            tesla.Model = "S";
            tesla.Price = 20000;
            tesla.EngineSize = 2.0;
            tesla.Mileage = 10;
            //static field
            Car.numberOfCars = 10;
            tesla.soldCar(1);
            tesla.soldCar(2);
            Console.WriteLine(Car.numberOfCars);

            tesla.Accelerate(175);
            Console.WriteLine(tesla.Speed);
        }
    }
}
