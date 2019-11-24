
namespace PizzaCallories
{
    using System;
    using System.Collections.Generic;
    public class Pizza
    {
        private string name;
        private Dough doughCurrent = null;
        private List<Topping> toppingsList;

        public Pizza(string name)
        {
            Name = name;
            ToppingsList = new List<Topping>();
        }

        public void AddDough(Dough dough)
        {
            doughCurrent = dough;
        }
        public double CalculateCalories()
        {
            var result = 0.0;
            result += doughCurrent.Callories();
            if (ToppingsList.Count > 0 && ToppingsList.Count <= 10)
            {
                foreach (var top in toppingsList)
                {
                    result += top.Callories();
                }
            }
            else
            {
                throw new ArgumentException
                    ($"Number of toppings should be in range [0..10].");
            }
            return result;
        }

        public override string ToString()
        {
            var result = "";
            var cal = CalculateCalories();
            result += $"{this.Name} - {cal:F2} Calories.";
            return result;
        }

        public void AddTopping(Topping topping)
        {
            ToppingsList.Add(topping);
        }
        public List<Topping> ToppingsList
        {
            get 
            {
                return toppingsList; 
            }
            private set 
            {
                toppingsList = value; 
            }
        }

        public string Name
        {
            get { return name; }
            private set 
            { 
                if(string.IsNullOrWhiteSpace(value) ||
                    string.IsNullOrEmpty(value) ||
                    value.Length > 15)
                {
                    throw new System.ArgumentException(
                        "Pizza name should be between 1 and 15 symbols."
                        );
                }
                name = value; 
            }
        }

    }
}
