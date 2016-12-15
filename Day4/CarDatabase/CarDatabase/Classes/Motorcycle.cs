using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDatabase.Classes
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
    }
}
