using System;
using System.Collections.Generic;

namespace _02_car_salesman
{
     class Program
    {
        public static List<Engine> engines = new List<Engine>();
        public static List<Car> cars = new List<Car>();

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var engineInput = Console.ReadLine().Split();
                var model = engineInput[0];
                var power = int.Parse(engineInput[1]);
                int displacement = 0;
                string efficiancy = null;
                if(engineInput.Length >= 3)
                {
                    var tryParse = int.TryParse(engineInput[2], out displacement);
                    if (!tryParse)
                    {
                        efficiancy = engineInput[2];
                    }
                }
                if (engineInput.Length >= 4)
                {
                    efficiancy = engineInput[3];
                }
                var engine = new Engine(model, power, displacement, efficiancy);
                engines.Add(engine);
            }

            var m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var carInput = Console.ReadLine().Split();
                var model = carInput[0];
                var engineModel = carInput[1];
                var weigth = 0;
                string collor = null;
                if (carInput.Length >= 3)
                {
                    var tryParse = int.TryParse(carInput[2], out weigth);
                    if (!tryParse)
                    {
                    collor = carInput[2];
                    }
                }
                if (carInput.Length == 4)
                {
                    collor = carInput[3];
                }
                var engine = engines.Find(e => e.Model == engineModel);
                var car = new Car(model, engine, weigth, collor);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
