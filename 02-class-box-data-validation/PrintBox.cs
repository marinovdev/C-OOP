using System;

namespace _01_class_box
{
    class PrintBox
    {
        static void Main(string[] args)
        {
            double l = int.Parse(Console.ReadLine());
            double w = int.Parse(Console.ReadLine());
            double h = int.Parse(Console.ReadLine());
            BoxFigure box = new BoxFigure(l, w, h);

            box.Area();
            box.LateralSurfaceArea();
            box.Volume();
        }
    }
}
