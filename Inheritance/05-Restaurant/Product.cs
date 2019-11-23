﻿
namespace Restaurant
{
    class Product
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public virtual decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
