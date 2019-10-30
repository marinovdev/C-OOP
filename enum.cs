using System;

namespace z_scratchpad
{
    class Program
    {
            public enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun}
        static void Main(string[] args)
        {
            PrintDay(Day.Mon);
        }

        public static void PrintDay(Day day)
        {
            Console.WriteLine(day); // Mon
        }
    }
}
