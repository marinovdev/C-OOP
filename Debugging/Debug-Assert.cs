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

            Debug.Assert(num == 100, "num is not 100"); // Assertion failed. num is not 100
        }
    }
}
