using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2Homework
{
    class DefiningClassesPart2
    {
        static void Main()
        {
            //Test Problems 1-4
            Point3D point = new Point3D(1, 1, 2);
            Console.WriteLine("My point: {0}",point.ToString());
            Console.WriteLine("Point O:{0}",Point3D.O.ToString());
            
            Point3D firstPoint = new Point3D(1, 1, 1);
            Point3D secondPoint = new Point3D(2, 2, 2);
            double distance = Distance.CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine("Distance:{0:F2}", distance);

            List<Point3D> path = new List<Point3D>();
            path.Add(firstPoint);
            path.Add(secondPoint);
            PathStorage.SavePath(path);
            Console.WriteLine("Path saved in SavePath.txt");
            List<Point3D> loadedPath = PathStorage.LoadPath();
            Console.WriteLine("Path loaded:");
            foreach (var item in loadedPath)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));
            //Test Problems 5-7
            try
            {
                GenericList<int> listInt = new GenericList<int>(5);
                for (int i = 0; i < 10; i++)
                {
                    listInt.AddElement(i);
                }
                Console.WriteLine(listInt.ToString());
                Console.WriteLine("Min element {0}",listInt.Min());
                Console.WriteLine("Max element {0}",listInt.Max());

                int index = 0;
                listInt.RemoveElement(index);
                Console.WriteLine("Remove element: {0}",listInt.ToString());

                index = 8;
                int target = 0;
                listInt.InsertElement(0, index);
                Console.WriteLine("Insert element: {0}",listInt.ToString());
                target = 0;
                index = listInt.FindElement(target);
                if (index > 0)
                {
                    Console.WriteLine("Target:{0} found at index {1}", target, index);
                }
                else
                {
                    Console.WriteLine("Target not found");
                }
                index = 0;
                Console.WriteLine("Element at index {0} is {1}", index, listInt.GetElement(index));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(new string('-', 20));
            //Test Problems 8-11
            try
            {
                Matrix<int> m1 = new Matrix<int>(2, 2);
                Console.WriteLine("Fill matrix m1:");
                FillMatrix(m1);
                Matrix<int> m2 = new Matrix<int>(2, 2);
                Console.WriteLine("Fill matrix m2:");
                FillMatrix(m2);
                Matrix<int> addResult = m1 + m2;
                Console.WriteLine("Result addition:");
                Console.WriteLine(addResult.ToString());
                Matrix<int> subResult = m1 - m2;
                Console.WriteLine("Result subtraction:");
                Console.WriteLine(subResult.ToString());
                Matrix<int> multiplyResult = m1 * m2;
                Console.WriteLine("Result multiplication:");
                Console.WriteLine(multiplyResult.ToString());
                Console.WriteLine("Check for non-zero elements in first matrix:");
                if (m1)
                {
                    Console.WriteLine("There aren't zero element in matrix");
                }
                else
                {
                    Console.WriteLine("There is zero elements in matrix");
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Error: Number of the colums of first matrix \nshould be equal to rows of second matrix");               
            }
            Console.WriteLine(new string('-', 20));
            //Test Problem 12
            var test = typeof(TestAttribute);
            object[] attributes = test.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in attributes)
            {
                Console.WriteLine("Version: {0}", attribute.Version);
            }
        }

        private static void FillMatrix(Matrix<int> m1)
        {
            for (int i = 0; i < m1.Row; i++)
            {
                for (int j = 0; j < m1.Col; j++)
                {
                    Console.Write("m[{0},{1}]=",i , j);
                    m1[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
