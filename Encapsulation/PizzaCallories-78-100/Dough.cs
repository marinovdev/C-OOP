
namespace PizzaCallories
{
using System;
using System.Linq;
    public class Dough
    {
        public const double baseCallories = 2;
        private static readonly string[] flourtTypes = {"White", "Wholegrain" };
        private static readonly string[] techniquesList = { "Crispy", "Chewy", "Homemade" };

        private string flourType; // white or wholegrain
        private string technique; // crispy, chewy or homemade
        private double weight;

        public Dough(string flourType, string technique, double weight)
        {
            Weight = weight;
            Technique = technique;
            FlourType = flourType;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public double Callories()
        {
            var result = 0.0;
            var calories = baseCallories * Weight;
            if (string.Equals(FlourType, "White", StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= Modifiers.White;
            }
            else
            {
                calories *= Modifiers.Wholegrain;
            }
            if (string.Equals(Technique, "Crispy", StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= Modifiers.Crispy;
            }
            else if (string.Equals(Technique, "Chewy", StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= Modifiers.Chewy;
            }
            else if (string.Equals(Technique, "Homemade", StringComparison.CurrentCultureIgnoreCase))
            {
                calories *= Modifiers.Homemade;
            }
            result = calories;
            return result;
        }
        public double Weight
        {
            get { return weight; }
            set 
            { 
                if(value < 1 || value > 200)
                {
                    throw new System.ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value; 
            }
        }

        public string Technique
        {
            get { return technique; }
            set 
            {
                if (!techniquesList
                    .Any(t => string.Equals(t, value, StringComparison.CurrentCultureIgnoreCase)))
                {
                    throw new System.Exception("Invalid type of dough.");
                }
                technique = value; 
            }
        }

        public string FlourType
        {
            get { return flourType; }
            set 
            { 
                if(!flourtTypes.Any( f => string
                .Equals(f, value, StringComparison.CurrentCultureIgnoreCase)))
                {
                    throw new System.ArgumentException("Invalid type of dough.");
                    return;
                }
                flourType = value; 
            }
        }

    }

    struct Modifiers
    {
        public const double White = 1.5;
        public const double Wholegrain = 1.0;
        public const double Crispy = 0.9;
        public const double Chewy = 1.1;
        public const double Homemade = 1.0;

    }
}
