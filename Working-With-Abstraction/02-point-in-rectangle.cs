using System;
using System.Linq;

namespace _01_abstraction_exercise
{
    class PointsInRectangle
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int leftX = input[0];
            int leftY = input[1];
            int rightX = input[2];
            int rightY = input[3];
            var rectangle = new Rectangle(leftX, leftY, rightX, rightY);
            var iterations = int.Parse(Console.ReadLine());
            for (int i = 0; i < iterations; i++)
            {
                var contains = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                Console.WriteLine(rectangle.Contains(contains[0], contains[1]));
            }
        }
    }

    class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

    }

    class Rectangle
    {
        private int leftX;
        private int leftY;
        private int rightX;
        private int rightY;

        public Rectangle(int leftX, int leftY, int rightX, int rightY)
        {
            this.leftX = leftX;
            this.leftY = leftY;
            this.rightX = rightX;
            this.rightY = rightY;
        }

        public string Contains(int x, int y)
        {
            var output = "False";
            var xCoordinates = (x >= leftX && x <= rightX) || (x <= leftX && x >= rightX);
            var yCoordinates = (y >= leftY && y <= rightY) || (y <= leftY && y >= rightY);
            if(xCoordinates && yCoordinates)
            {
                output = "True";
            }
            return output;
        }

    }
}
