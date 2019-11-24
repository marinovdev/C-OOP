
namespace PizzaCallories
{
    using System;
    class StartUp
    {
        public static void Main()
        {
            Pizza pizza = null;
            try
            {
                var input = Console.ReadLine()
                    .Split(' ');
                pizza = new Pizza(input[1]);
                var args = Console.ReadLine().Split();
                var flour = args[1];
                var technique = args[2];
                var weight = int.Parse(args[3]);
                var dough = new Dough(flour, technique, weight);
                if (dough != null)
                {
                    pizza.AddDough(dough);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            var command = "";
            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    var arr = command.Split();
                    var toppingName = arr[1];
                    var weightTopping = int.Parse(arr[2]);
                    var topping = new Topping(toppingName, weightTopping);
                    if (topping != null)
                    {
                        pizza.AddTopping(topping);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }

            try
            {
                Console.WriteLine(pizza.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
