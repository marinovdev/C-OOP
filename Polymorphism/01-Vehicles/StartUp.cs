using System;
using System.Linq;

namespace _01_Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public abstract void Drive(double killometers);

        public abstract void RefuelCar(double litters);

        public abstract double FuelQuantity { get; set; }

        public abstract double FuelConsumption { get; set; }

        public abstract double FuelLoss { get;}

    }

    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {

        }

        public override double FuelQuantity { get; set; }
        public override double FuelConsumption { get; set; }
        public override double FuelLoss { get => 0.9;}

        public override void Drive(double killometers)
        {
            if (this.FuelQuantity - (this.FuelConsumption + this.FuelLoss) * killometers >= 0)
            {
                this.FuelQuantity -= (this.FuelConsumption + this.FuelLoss) * killometers;
                Console.WriteLine($"Car travelled {killometers} km");
            }
            else
                Console.WriteLine($"Car needs refueling");
        }

        public override void RefuelCar(double litters)
        {
            this.FuelQuantity += litters;
        }
    }

    public class Truck : Vehicle
    {

        private const double _refuilingLoss = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double FuelQuantity { get; set; }
        public override double FuelConsumption { get; set; }

        public override double FuelLoss => 1.6;

        public override void Drive(double killometers)
        {
            if (this.FuelQuantity - (this.FuelConsumption + this.FuelLoss) * killometers >= 0)
            {
                this.FuelQuantity -= (this.FuelConsumption + this.FuelLoss) * killometers;
                Console.WriteLine($"Truck travelled {killometers} km");
            }
            else
                Console.WriteLine($"Truck needs refueling");
        }

        public override void RefuelCar(double litters)
        {
            this.FuelQuantity += litters / 100 * 95;
        }
    }
    public static class StartUp
    {
       public  static void Main()
        {
            var carParams = Console.ReadLine()
                .Split();

            var truckParams = Console.ReadLine()
                .Split();

            var car = new Car(double.Parse(carParams[1]), double.Parse(carParams[2]));
            var truck = new Truck(double.Parse(truckParams[1]), double.Parse(truckParams[2]));

            var iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                var command = Console.ReadLine().Split();

                var operation = command[0];
                var vehicle = command[1];

                if(operation == "Drive")
                {
                    var distance = double.Parse(command[2]);
                    if (vehicle == "Car")
                    {
                        car.Drive(distance);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Drive(distance);
                    }
                }
                else
                {
                    var ammount = double.Parse(command[2]);
                    if (vehicle == "Car")
                    {
                        car.RefuelCar(ammount);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.RefuelCar(ammount);
                    }
                }
            }
            var carFuel = Math.Round(car.FuelQuantity, 2, MidpointRounding.AwayFromZero);
            var truckFuel = Math.Round(truck.FuelQuantity, 2, MidpointRounding.AwayFromZero);

            Console.WriteLine($"Car: {carFuel:F2}");
            Console.WriteLine($"Truck: {truckFuel:F2}");
        }
    }
}
