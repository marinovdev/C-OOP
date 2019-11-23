

namespace NeedForSpeed
{
using System.ComponentModel;
    class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }

        [DefaultValue(8)]
        public override double DefaultFuelConsumption { get; set; } = 8;
    }
}
