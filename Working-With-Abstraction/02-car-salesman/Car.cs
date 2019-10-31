using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_car_salesman
{
    class Car
    {
       
        public Car(string model, Engine engine, int weigth, string color)
        {
            Model = model;
            Engine = engine;
            Weigth = weigth;
            Color = color;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"  {this.Model}:");
            //var engine = Program.engines.First(e => e.Model == );
            sb.AppendLine($"    {this.Engine.Model}");
            if (this.Engine.Power == 0)
            {
                sb.AppendLine($"    Power: n/a");
            }
            else
            {
                sb.AppendLine($"    Power: {this.Engine.Power}");
            }
            if (this.Engine.Displacement == 0)
            {
                sb.AppendLine($"    Displacement: n/a");
            }
            else
            {
                sb.AppendLine($"    Displacement: {this.Engine.Displacement}");
            }
            if (this.Engine.Efficiancy == null)
            {
                sb.AppendLine($"    Efficiency: n/a");
            }
            else
            {
                sb.AppendLine($"    Efficiency: {this.Engine.Efficiancy}");
            }
            if (this.Weigth == 0)
            {
                sb.AppendLine($"  Weight: n/a");
            }
            else
            {
                sb.AppendLine($"  Weight: {this.Weigth}");
            }
            if (this.Color == null)
            {
                sb.AppendLine($"  Color: n/a");
            }
            else
            {
                sb.AppendLine($"  Color: {this.Color}");
            }

            return sb.ToString().TrimEnd();
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weigth { get; set; }
        public string Color { get; set; }


    }
}
