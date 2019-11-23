
namespace Restaurant
{
    class Beverage : Product
    {
        public Beverage(string name, decimal price, double milimeters) : base(name, price)
        {
            this.Name = name;
            this.Price = price;
            this.Millimeters = milimeters;
        }

        public override string Name { get; set; }
        public override decimal Price { get; set; }
        public virtual double Millimeters { get; set; }
    }
}
