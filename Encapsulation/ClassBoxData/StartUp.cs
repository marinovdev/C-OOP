
namespace ClassBoxData
{
using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var line1 = double.Parse(Console.ReadLine());
            var line2 = double.Parse(Console.ReadLine());
            var line3 = double.Parse(Console.ReadLine());

            Box box = null;

            try
            {
                box = new Box(line1, line2, line3);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            box.SurfaceArea();
            box.LateralSurfaceArea();
            box.Volume();

        }
    }

    class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        public void SurfaceArea()
        {
            var surfaceArea = 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
            Console.WriteLine($"Surface Area - {surfaceArea:F2}");
        }

        public void LateralSurfaceArea()
        {
            var LateralSurfaceArea = 2 * Length * Height + 2 * Width * Height;
            Console.WriteLine($"Lateral Surface Area - {LateralSurfaceArea:F2}");
        }

        public void Volume()
        {
            var volume = Length * Height * Width;
            Console.WriteLine($"Volume - {volume:F2}");
        }
        public double Height
        {
            get { return height; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        public double Width
        {
            get { return width; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }

        public double Length 
        { 
            get =>  this.length; 
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value;
            }
        }
    }
}
