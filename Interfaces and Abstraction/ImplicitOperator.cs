
namespace ImplicitOperator
{
using System;
    class Example
    {
        static void Main()
        {
            DataType variable = "Ivan";
        }
    }

    class DataType
    {
        public static implicit operator DataType(string b) => new DataType();
    }
}
