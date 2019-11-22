namespace CustomRandomList
{
using System;
using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            var list = new RandomList() { "a1", "b2", "c", "d", "e", "f" };

            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
        }
    }

    class RandomList : List<string>
    {
        public string RandomString()
        {
            var result = "";
            var rnd = new Random();
            var index = rnd.Next(0, this.Count - 1);
            result = this[index];
            this.RemoveAt(index);
            return result;
        }
    }

}
