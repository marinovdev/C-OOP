
namespace Restaurant
{
    class Food : Product
    {
        public Food(string name, decimal price, double grams) : base(name, price)
        {
            Name = name;
            Price = price;
            Grams = grams;
        }
        public virtual double Grams { get; set; }
    }
}
