using System;
using System.Collections.Generic;
using System.Text;

namespace _02_car_salesman
{
    class Engine
    {
        public Engine(string model, int power, int displacement, string efficiancy)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiancy = efficiancy;
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiancy { get; set; }

    }
}
