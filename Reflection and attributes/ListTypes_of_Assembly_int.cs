using System;

namespace ListTypes_of_Assembly_int
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = typeof(int).Assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine(type); // lists all classes in the int class
            }
        }
    }
}
