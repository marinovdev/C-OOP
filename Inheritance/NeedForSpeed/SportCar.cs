

namespace NeedForSpeed
{
using System.ComponentModel;
    class SportCar : Car
    {
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
        [DefaultValue(10)]
        public override double DefaultFuelConsumption { get; set; } = 10;
    }
}
