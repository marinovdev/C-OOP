
using System;

namespace _01_class_box
{
    public class BoxFigure
    {
        // figure box with parameters length, width and height
        private double length;
        private double width;
        private double height;

        public BoxFigure(double length,double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        //double length, double width, double height
        public void Area()
        {
            double surfaceArea = 2 * (length * width) + 2 * (length * height) + 2 * (width * height);
            System.Console.WriteLine($"Surface Area – {surfaceArea}");
        }
        public void LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (length * height) + 2 * (width * height);
            System.Console.WriteLine($"Lateral Surface Area – {lateralSurfaceArea}");
        }
        public void Volume()
        {
            double Volume = length * width * height;
            System.Console.WriteLine($"Volume – {Volume}");
        }
       
        public double Length
        {

            set
            {
                if(value <= 0 )
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }
                this.length = value;
            }
        }
        public double Width
        {

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public double Height
        {

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }
                this.height = value;
            }
        }
    }
}
