using System;
using System.Reflection;

namespace Classes_in_Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var item in types)
            {
                Console.WriteLine(item);
            }
                //Classes_in_Assembly.Program
                //Classes_in_Assembly.Person
                //Classes_in_Assembly.Admin
                //Classes_in_Assembly.Menu
        }
    }

    class Person
    {

    }

    class Admin
    {

    }

    class Menu
    {

    }
}
