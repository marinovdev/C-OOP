
namespace Ferrari
{
using System;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var ferrari = new Ferrari(input);
            Console.WriteLine($"{ferrari.Model}/{ferrari.Brakes()}/" +
                $"{ferrari.Gas()}/{ferrari.Name}");
        }
    }

    public class Ferrari : ICar
    {
        public string Model = "488-Spider";

        public Ferrari(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }
    }

    public interface ICar
    {
        string Brakes();

        string Gas();
    }
}
