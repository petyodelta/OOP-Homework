using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    public static class StudentsExtensions
    {
        public static List<Students> FindStudentsFromGroupTwo(this List<Students> students)
        {
            List<Students> result = new List<Students>();
            foreach (var student in students)
            {
                if (student.StudentGroupNumber.GroupNumber == 2)
                {
                    result.Add(student);
                }
            }
            
            return result;
        }

        public static List<Students> FindStudentsWithTwoMarks2(this List<Students> students)
        {
            List<Students> result = new List<Students>();
            int counter = 0;
            foreach (var student in students)
            {
                for (int i = 0; i < student.Marks.Count; i++)
                {
                    if (student.Marks[i] == 2)
                    {
                        ++counter;
                        if (counter == 2)
                        {
                            result.Add(student);
                        }
                    }
                }
                counter = 0;
            }
            return result;
        }
        
        public static List<Students> GroupStudentsByGroupName(this List<Students> students)
        {
            var result = students.OrderBy(student => student.StudentGroupNumber.DepartmentName);
            return result.ToList<Students>();
        }

        
    }
}
