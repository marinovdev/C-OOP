
namespace Restaurant
{
    class Coffee : HotBeverage
    {
        private const double coffeeMilliliters = 50;
        private const decimal coffeePrice = 3.50M;
        public Coffee(string name, decimal price, double milimiters) : base(name, price, milimiters)
        {

        }

        public override double Millimeters { get => coffeeMilliliters; }
        public override decimal Price { get => coffeePrice; }
        public double Caffeine { get; set; }
    }
}
