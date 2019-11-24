

namespace PizzaCallories
{
using System;
using System.Linq;
    public class Topping
    {
        private static double baseCallories = 2;
        private static readonly string[] toppingsList = 
            { "Meat", "Veggies","Cheese", "Sauce" };
        private string type;
        private double weight;

        public Topping( string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public double Callories()
        {
            var result = 0.0;
            var calories = baseCallories * Weight;
            if (string.Equals(Type, "Meat", StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= ToppingModifiers.Meat;
            }
            else if (string.Equals(Type, "Veggies", StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= ToppingModifiers.Veggies;
            }
            else if (string.Equals(Type, "Cheese", StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= ToppingModifiers.Cheese;
            }
            else if (string.Equals(Type, "Sauce", StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= ToppingModifiers.Sauce;
            }
            result = calories;
            return result;
        }
        public double Weight
        {
            get { return weight; }
            private set 
            {
                if (value < 1 || value > 50)
                {
                    throw new System.ArgumentException
                        (
                        $"{this.Type} weight should be in the range[1..50]."
                        );
                }
                weight = value; 
            }
        }

        public string Type
        {
            get { return type; }
            private set 
            { 
                if(!toppingsList.Any(t => string.Equals(t, value, StringComparison.CurrentCultureIgnoreCase)))
                {
                    throw new System.ArgumentException
                        (
                        $"Cannot place {value} on top of your pizza."
                        );
                }
                type = value; 
            }
        }

    }

    struct ToppingModifiers
    {
           public const double Meat = 1.2;
           public const double Veggies = 0.8;
           public const double Cheese = 1.1;
           public const double Sauce = 0.9;
    }
}
