using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_jedi_galaxy
{
    class JediGalaxy
    {
        public static int ivoCollectedStars = 0;
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            var space = new int[dimensions[0], dimensions[1]];
            var starValue = 0;
            for (int i = 0; i < space.GetLength(0); i++)
            {
                for (int j = 0; j < space.GetLength(1); j++)
                {
                    space[i, j] = starValue;
                    starValue++;
                }
            }

            var command = Console.ReadLine();
            while(command != "Let the Force be with you")
            {
                var ivoLocation = command.Split()
                    .Select(int.Parse)
                    .ToArray();
                var darkForceLocation = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();
                //dark Force Values
                    var darkForceRow = darkForceLocation[0];
                    var darkForceCol = darkForceLocation[1];
                //Ivo Values
                var ivoRow = ivoLocation[0];
                var ivoCol = ivoLocation[1];
                while (darkForceRow >= 0)
                {
                    if (darkForceRow < space.GetLength(0) && darkForceCol < space.GetLength(1)
                        && darkForceCol >= 0 && darkForceRow >= 0)
                    {
                        space[darkForceRow, darkForceCol] = 0;
                    }
                    darkForceCol--;
                    darkForceRow--;
                }
                // Ivo movement
                while (ivoRow >= 0)
                {
                    if (ivoRow < space.GetLength(0) && ivoCol >= 0 && ivoRow >= 0 
                        && ivoCol < space.GetLength(1))
                    {
                            ivoCollectedStars += space[ivoRow, ivoCol];
                    }
                        ivoCol++;
                        ivoRow--;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(ivoCollectedStars);
            //
            //for (int i = 0; i < space.GetLength(0); i++)
            //{
            //    for (int j = 0; j < space.GetLength(1); j++)
            //    {
            //        Console.Write(space[i, j].ToString().PadLeft(2, ' ') + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
