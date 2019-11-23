
namespace NeedForSpeed
{
using System.ComponentModel;
    class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
        [DefaultValue(3)]
        public override double DefaultFuelConsumption { get; set; } = 3;
    }
}
