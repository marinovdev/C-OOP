
namespace NeedForSpeed
{ 
using System.ComponentModel;
    class Vehicle
    {
        private double fuelConsumption;
        private double fuel;
        private double defaultFuelConsumption = 1.25;
        private int horsePower;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        [DefaultValue(1.25)]
        public virtual double DefaultFuelConsumption 
        {
            get
            {
                return defaultFuelConsumption;
            }
            set 
            { 
                defaultFuelConsumption = value; 
            }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

       public virtual void Drive(double kilometers)
        {
            this.Fuel = this.Fuel - kilometers;
        }
    }
}
