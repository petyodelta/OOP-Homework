using _1.Shapes.Models;
using System;

namespace _1.Shapes
{
    class ShapesMain
    {
        static void Main()
        {
            Shape[] shapeArray = new Shape[]
            {
                new Triangle(3,5),
                new Rectangle(5,7),
                new Square(6)
            };

            foreach (var item in shapeArray)
            {
                double surface = item.CalculateSurface();
                Console.WriteLine("Surface is {0}",surface);
            }
        }
    }
}
