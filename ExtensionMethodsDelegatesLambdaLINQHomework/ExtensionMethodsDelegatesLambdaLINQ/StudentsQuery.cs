using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    static class StudentsQuery
    {
        public static Students[] FindFirstBeforeLastName(Students[] students)
        {
            var result =
                from student in students
                where string.Compare(student.FirstName, student.LastName) < 0
                select student;
            return result.ToArray<Students>();
        }

        public static Students[] FindAgeBetween(Students[] students)
        {
            var result =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;
            return result.ToArray<Students>();
        }

        public static Students[] SortStudentsLambda(Students[] students)
        {
            var sortedStudents =
                students.OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName);
            return sortedStudents.ToArray<Students>();
        }

        public static Students[] SortStudentsLinq(Students[] students)
        {
            var sortedStudents =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;
            return sortedStudents.ToArray<Students>();
        }

        public static List<Students> SelectFromGroup(List<Students> students)
        {
            var result =
                from student in students
                where student.StudentGroupNumber.GroupNumber == 2
                orderby student.FirstName
                select student;
            return result.ToList<Students>();
        }

        public static List<Students> ExtractByEmail (List<Students> students)
        {
            var result =
                from student in students
                where student.Email.EndsWith("abv.bg")
                select student;
            return result.ToList<Students>();
        }

        public static List<Students> ExtractByTelephone(List<Students> students)
        {
            var result =
                from student in students
                where student.Tel.StartsWith("+3592") || student.Tel.StartsWith("003592")
                select student;
            return result.ToList<Students>();
        }

        public static List<Students> ExtractByMarks(List<Students> students)
        {
            var result =
                from student in students
                where student.Marks.Contains(6)
                select student;
            return result.ToList<Students>();
        }

        public static List<Students> ExtractAllMarksByYear(List<Students> students)
        {
            var result =
                from student in students
                where student.FN.EndsWith("06")
                select student;
            return result.ToList<Students>();
        }

        public static string LongestString(string[] str)
        {
            var result =
                (from s in str
                orderby s.Length descending
                select s).FirstOrDefault();
            return result.ToString();
        }

        public static List<Students> ExtractByDepartment(List<Students> students, List<Group> groups)
        {
            var result =
                from student in students
                join g in groups on student.StudentGroupNumber.DepartmentName equals g.DepartmentName
                select student;
            return result.ToList<Students>();
        }

        public static List<Students> GroupByGroupNumber(List<Students> students)
        {
            var result =
            from student in students
            orderby student.StudentGroupNumber.DepartmentName
            select student;
            return result.ToList<Students>();
        }
    }
}
