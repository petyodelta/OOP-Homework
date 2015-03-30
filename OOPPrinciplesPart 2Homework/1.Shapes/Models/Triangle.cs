
namespace _1.Shapes.Models
{
    public class Triangle : Shape
    {
        public Triangle(int height, int width) : base(height, width)
        {

        }

        public override double CalculateSurface()
        {
            return (Height * Width) / 2.0;
        }
    }
}
