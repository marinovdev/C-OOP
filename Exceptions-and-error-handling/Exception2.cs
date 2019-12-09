using System;

namespace Exception2
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
				throw ex; // Removes the details by specifing the exception instance
			}
			catch (ArithmeticException ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("Custom typed exception");
				throw ex;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("Custom typed exception");
				throw ex;
			}
		}
    }
}
