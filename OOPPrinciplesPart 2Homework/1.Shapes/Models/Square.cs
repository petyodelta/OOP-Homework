
namespace _1.Shapes.Models
{
    public class Square : Shape
    {
        public Square(int side)
        {
            this.Height = side;
            this.Width = side;
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
