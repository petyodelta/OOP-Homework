using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolClasses
{
    class SchoolClasses
    {
        static void Main()
        {
            Discipline[] setDisciplineOne = {new Discipline("Math"), new Discipline("C#")};
            Teacher firstTeacher = new Teacher("Ivan", setDisciplineOne);
            Console.WriteLine(firstTeacher);

            Console.WriteLine(new string('-', 30));
            Discipline[] setDisciplineTwo = {new Discipline("OOP"), new Discipline("Python")};
            Teacher secondTeacher = new Teacher("Boris", setDisciplineTwo);

            Teacher[] setTeachers = new Teacher[] { firstTeacher, secondTeacher };
            Classes classA = new Classes("Class A", setTeachers);
            Console.WriteLine(classA);

            Console.WriteLine(new string('-', 30));

        }
    }
}
