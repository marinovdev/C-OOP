using System;

namespace Attributes_Demo
{
    class Demo
    {
        static void Main(string[] args)
        {
            var car = new Car();

            Type type1 = car.GetType();
            Type type2 = typeof(Car);
            Type type3 = Type.GetType("Attributes_Demo.Car");

            Console.WriteLine(type3.ToString()); //Attributes_Demo.Car


        }
    }

    class Car
    {

    }
}
