using System.Collections.Generic;

namespace DefiningClassesPart2Homework
{
    class Path
    {
        private List<Point3D> list = new List<Point3D>();

        public Path() { }

        public void AddPoint(Point3D point)
        {
            list.Add(point);
        }
        public void DeletePoint(Point3D point)
        {
            list.Remove(point);
        }
        public void DeleteAllPoints()
        {
            list.Clear();
        }

    }
}
