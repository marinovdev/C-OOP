using System;
using System.Text;

namespace Console_Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("неразчетено"); // ???????
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("разчетено");
        }
    }
}
