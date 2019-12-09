using System;

namespace Exception3
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				BrokenMethod();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message); // Error !
			}
		}

		public static void BrokenMethod()
		{

			int num = 0;

			if (int.TryParse("w", out num))
			{
				Console.WriteLine("is number");
			}
			else
				throw new FormatException("Error !");
		}
    }
}
