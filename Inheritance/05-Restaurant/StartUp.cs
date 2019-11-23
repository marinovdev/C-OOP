using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using Restaurant;

[TestFixture]
public class Tests_000_001
{
    private static Assembly ProjectAssembly = typeof(StartUp).Assembly;

    [Test]
    public void ValidateTypesExist()
    {
        var typesToAssert = new[]
        {
                "Product",
                "Beverage",
                "Coffee",
                "ColdBeverage",
                "HotBeverage",
                "Tea",
                "Cake",
                "Dessert",
                "Food",
                "MainDish",
                "Fish",
                "Soup",
                "Starter"
        };

        foreach (string typeName in typesToAssert)
        {
            Assert.That(GetType(typeName), Is.Not.Null, $"{typeName} type doesn't exist!");
        }
    }

    private static Type GetType(string name)
    {
        var type = ProjectAssembly
            .GetTypes()
            .FirstOrDefault(t => t.Name == name);

        return type;
    }
}
namespace Restaurant
{
    public class StartUp
    {
        public static void Main()
        {

        }
    }
}
