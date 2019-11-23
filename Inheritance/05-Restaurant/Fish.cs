
namespace Restaurant
{
    class Fish : MainDish
    {
        //public Fish(string name, decimal price, double grams) : base(name, price, grams)
        //{

        //}
        public Fish(string name, decimal price) : base(name, price, 22)
        {
            this.Name = name;
            this.Price = price;
        }

        public override double Grams { get; set; } = 22;
    }
}
