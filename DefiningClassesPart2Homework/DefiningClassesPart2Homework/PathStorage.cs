using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace DefiningClassesPart2Homework
{
    static class PathStorage
    {
        public static void SavePath(List<Point3D> path)
        {
            StreamWriter writer = new StreamWriter(@"..\..\SavePath.txt",false);
            using (writer)
            {
                foreach (var item in path)
                {
                    writer.Write(item);
                    writer.WriteLine();
                }
            }
        }
        public static List<Point3D> LoadPath()
        {
            StreamReader reader = new StreamReader(@"..\..\SavePath.txt", false);
            List<Point3D> points = new List<Point3D>();
            using (reader)
            {
                
                string line = reader.ReadLine();
                while (line != null)
                {
                    int[] pointCoord = line.Split(' ').Select(int.Parse).ToArray();
                    points.Add(new Point3D( pointCoord[0],pointCoord[1], pointCoord[2]));
                    line = reader.ReadLine();
                }
            }
            return points;
        }
    }
}
