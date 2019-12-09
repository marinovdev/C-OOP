using System;
using System.Diagnostics;

namespace Debug_class
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string input = "20";

            Debug.WriteLineIf(int.TryParse(input, out num), "input is a number"); // In the Output window: input is a number
        }
    }
}
