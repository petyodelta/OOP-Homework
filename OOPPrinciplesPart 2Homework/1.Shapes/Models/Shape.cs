
namespace _1.Shapes.Models
{
    public abstract class Shape
    {
        private int height;
        private int width;

        public Shape()
        {
           
        }

        public Shape(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public abstract double CalculateSurface();
        
    }
}
