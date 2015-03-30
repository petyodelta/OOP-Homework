
namespace _1.Shapes.Models
{
    public class Rectangle : Shape
    {
        public Rectangle(int height, int width) : base(height, width)
        {

        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }

    }
}
