using System;
using System.Linq;

namespace _01_abstraction_exercise
{
    class RhombusFromStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i < n; i++)
            {
                var asterix = string.Concat(Enumerable.Repeat("* ", i));
                var pad =  n + counter;
                var line = asterix.PadLeft(pad, ' ');
                Console.WriteLine(line);
            counter++;

            }
            for (int i = n; i >= 1; i--)
            {
                var asterix = string.Concat(Enumerable.Repeat("* ", i));
                var pad = n + counter;
                var line = asterix.PadLeft(pad, ' ');
                Console.WriteLine(line);
                counter--;
            }
        }
    }
}
