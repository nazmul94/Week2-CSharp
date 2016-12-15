namespace PolymorphicCarDetails
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        
        public Car() { }

        public Car(string make, string model, int price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }

        public override string ToString()
        {
            string retVal = "\tThe " + Make + " " + Model + " and has a price of £" + Price + ".\n";
            return retVal;
        }
    }
}