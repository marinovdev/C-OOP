using System;
using System.Reflection;

namespace List_interfaces_in_class
{
    class Program
    {
        static void Main(string[] args)
        {
           // Car car = new Car();

            Type type = typeof(Car) ;
            BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
            FieldInfo[] fields = type.GetFields(flags);

            foreach (var field in fields)
            {
                Console.WriteLine(field); // Prints all fields in Car
            }
        }

        class Car
        {
            private int year;

            public string Name { get; set; }

            public object Clone()
            {
                return null;
            }

            public int CompareTo(object obj)
            {
                return 5;
            }

            public void Dispose()
            {
                Console.WriteLine("fdsf");
            }
        }

    }
}
