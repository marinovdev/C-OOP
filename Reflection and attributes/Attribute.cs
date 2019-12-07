using System;

namespace Attribute_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class AuthorAttribute : Attribute
    {
        public string Name { get; set; }
    }

    [Author(Name = "P. Marinov")] //Author is for short,  can be named AuthorAttribute
    public class Class1
    {
    }

    [Author(Name = "Ivaylo")]
    public class Class2
    {
    }
}
