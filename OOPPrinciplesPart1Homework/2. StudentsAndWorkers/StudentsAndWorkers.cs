using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class StudentsAndWorkers
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Ivan", "Ivanov", 66.7),
                new Student("Boris", "Borisov", 55.1),
                new Student("Petko", "Petkov", 33.5),
                new Student("Mitko", "Dimitrov", 80.1),
                new Student("Angel", "Angelov", 41.2),
                new Student("Emil", "Emilov", 25),
                new Student("Doncho", "Ivanov", 10),
                new Student("Georgi", "Dimitrov", 63.2),
                new Student("Pesho", "Petkov", 70.2),
                new Student("Ivan", "Savov", 38.9),
            };

            var sortedStudents =
                (from student in students
                 orderby student.Grade
                 select student).ToList<Student>();

            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));

            List<Worker> workers = new List<Worker>
            {
                new Worker("Ivan", "Borisov", 5, 250),
                new Worker("Boris", "Ivanov", 6, 270),
                new Worker("Petko", "Dimitrov", 5, 225),
                new Worker("Mitko", "Petkov", 8, 400),
                new Worker("Angel", "Emilov", 8, 375),
                new Worker("Emil", "Angelov", 7, 300),
                new Worker("Doncho", "Dimitrov", 4, 250),
                new Worker("Georgi", "Ivanov", 8, 325),
                new Worker("Pesho", "Savov", 8, 350),
                new Worker("Ivan", "Petkov", 4, 200)
            };

            var sortedWorkers =
                (from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker).ToList<Worker>();

            foreach (var item in sortedWorkers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
            List<Human> humanList = new List<Human>();
            foreach (var item in sortedStudents)
            {
                humanList.Add(item);
            }
            foreach (var item in sortedWorkers)
            {
                humanList.Add(item);
            }

            var result =
                (humanList.OrderBy(human=> human.FirstName)
                .ThenBy(human => human.LastName))
                .ToList<Human>();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
