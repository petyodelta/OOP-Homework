﻿using System;

namespace DefiningClassesPart2Homework
{
    static class Distance
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            return Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X) +
                             (point1.Y - point2.Y) * (point1.Y - point2.Y) +
                             (point1.Z - point2.Z) * (point1.Z - point2.Z));
        }
                
    }
}
