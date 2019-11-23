//using NUnit.Framework;
//using System;
//using System.Reflection;
//using System.Linq;
//using NeedForSpeed;

//[TestFixture]
//public class Tests_000_001
//{
//    private static Assembly ProjectAssembly = typeof(StartUp).Assembly;

//    [Test]
//    public void ValidateTypesExist()
//    {
//        var typesToAssert = new[]
//        {
//            "Car",
//            "CrossMotorcycle",
//            "FamilyCar",
//            "Motorcycle",
//            "RaceMotorcycle",
//            "SportCar",
//            "Vehicle",
//        };

//        foreach (string typeName in typesToAssert)
//        {
//            Assert.That(GetType(typeName), Is.Not.Null, $"{typeName} type doesn't exist!");
//        }
//    }

//    private static Type GetType(string name)
//    {
//        var type = ProjectAssembly
//            .GetTypes()
//            .FirstOrDefault(t => t.Name == name);

//        return type;
//    }
//}
namespace NeedForSpeed
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            //var familyCar = new FamilyCar(90, 555);
            //var sportCar = new SportCar(90, 555);
            //var raceMotorcycle = new RaceMotorcycle(90, 555);
            //var vechicle = new Vechicle(90, 555);

            //Console.WriteLine(familyCar.DefaultFuelConsumption);
            //Console.WriteLine(sportCar.DefaultFuelConsumption);
            //Console.WriteLine(raceMotorcycle.DefaultFuelConsumption);
            //Console.WriteLine(vechicle.DefaultFuelConsumption);
        }
    }
}
