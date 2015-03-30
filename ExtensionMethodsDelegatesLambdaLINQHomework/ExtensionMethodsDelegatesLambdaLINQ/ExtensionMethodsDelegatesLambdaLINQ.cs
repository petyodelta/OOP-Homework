using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    class ExtensionMethodsDelegatesLambdaLINQ
    {
        static void Main()
        {
            Console.WriteLine("Problem 1:");
            StringBuilder sb = new StringBuilder("Hello World");
            Console.WriteLine("Before: {0}", sb.ToString());
            sb = sb.SubStringBuilder(0, 5);
            Console.WriteLine("After: {0}", sb.ToString());

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 2:");
            IEnumerable<int> collection = new int[] { 1, 2, 3, 4 };

            Console.WriteLine("Sum is {0}", collection.SumIEnumerable().ToString());
            Console.WriteLine("Product is {0}", collection.ProductIEnumerable().ToString());
            Console.WriteLine("Min element is {0}", collection.MinIEnumerable().ToString());
            Console.WriteLine("Max element is {0}", collection.MaxIEnumerable().ToString());
            Console.WriteLine("Average is {0}", collection.AverageIEnumerable().ToString());

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 3: ");
            Students[] students = new Students[]
            {
                new Students{FirstName = "Ivan", LastName = "Antonov", Age = 20, FN = "123405", Tel = "+3592 44 55 66", Email = "ivan@gmail.com",
                    StudentGroupNumber = new Group(2, "Mathematics"), Marks = new List<int>{2,5,2}},
                new Students{FirstName = "Angel", LastName = "Petkov", Age = 25, FN = "123406", Tel = "0888 44 55 77", Email = "angel@gmail.com",
                    StudentGroupNumber = new Group(1, "Electronics"), Marks = new List<int>{5,2,2}},
                new Students{FirstName = "Boris", LastName = "Savov", Age = 17, FN = "123407", Tel = "003592 44 55 88", Email = "boris@gmail.com",
                    StudentGroupNumber = new Group(1, "Electronics"), Marks = new List<int>{5,4,6}},
                new Students{FirstName = "Ivan", LastName = "Ivanov", Age = 27, FN = "123408", Tel = "0898 44 55 99", Email = "ivan@abv.bg",
                    StudentGroupNumber = new Group(2, "Mathematics"), Marks = new List<int>{5,5,4}}
            };

            foreach (var item in StudentsQuery.FindFirstBeforeLastName(students))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 4: Students with age between 18 and 24 are:");
            foreach (var item in StudentsQuery.FindAgeBetween(students))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 5: Sorted with Lambda");
            foreach (var item in StudentsQuery.SortStudentsLambda(students))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 5: Sorted with Linq");
            foreach (var item in StudentsQuery.SortStudentsLinq(students))
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 6: Divisible by 7 and 3 with Lambda");
            int[] intArray = { 1, 3, 5, 7, 21 };
            var lambdaArray = intArray.Where(num => (num % 3)== 0 && (num % 7) == 0);
            PrintArray(lambdaArray);

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 6: Divisible by 7 and 3 with Linq");
            var linqArray =
                from number in intArray
                where (number % 3 == 0) && (number % 7 == 0)
                select number;
            PrintArray(linqArray);
            
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 7: Execute certain method at each t seconds.");
            MyDelegate d = new MyDelegate(Timer.TestMethod);
            Timer timer = new Timer(2, d);
            timer.ExecuteTimer(3);//Execute three times

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 9: Select students from group 2 with Linq:");
            List<Students> listStudents = students.ToList<Students>();
            
            foreach (var item in StudentsQuery.SelectFromGroup(listStudents))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 10: Select students from group 2 with extension method");
            foreach (var item in listStudents.FindStudentsFromGroupTwo())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 11: Select students with email in abv.bg:");
            foreach (var item in StudentsQuery.ExtractByEmail(listStudents))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 12: Extract students with telephone in Sofia:");
            foreach (var item in StudentsQuery.ExtractByTelephone(listStudents))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 13: Extract students with at least one 6:");
            foreach (var item in StudentsQuery.ExtractByMarks(listStudents))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 14: Students with two marks \"2\":");
            foreach (var item in listStudents.FindStudentsWithTwoMarks2())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 15:Students that enroled in 2006:");
            foreach (var item in StudentsQuery.ExtractAllMarksByYear(listStudents))
            {
                Console.Write(item);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 16: Extract all students from Mathematics department:");
            List<Group> groups = new List<Group>();
            groups.Add(new Group(2,"Mathematics"));
            foreach (var item in StudentsQuery.ExtractByDepartment(listStudents, groups))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 17: Longest string:");
            string[] str = new string[] {"Hello", "students", "from", "Telerik", "academy"};
            Console.WriteLine(StudentsQuery.LongestString(str));

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 18:  Grouped by GroupNumber with Linq:");
            foreach (var item in StudentsQuery.GroupByGroupNumber(listStudents))
            {
                Console.Write(item);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Problem 19: Group with extension method:");
            foreach (var item in listStudents.GroupStudentsByGroupName())
            {
                Console.Write(item);
            }
        }

        private static void PrintArray(IEnumerable<int> linqArray)
        {
            foreach (var item in linqArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
