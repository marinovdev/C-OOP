using System;

namespace Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				var input = int.Parse("p");
			}
			catch (FormatException ex)
			{
				Console.WriteLine(ex.Message); // The string was not in a correct format
				Console.WriteLine("Custom typed exception");
				
			}
			catch (ArithmeticException ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("Custom typed exception");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("Custom typed exception");
			}
		}
    }
}
