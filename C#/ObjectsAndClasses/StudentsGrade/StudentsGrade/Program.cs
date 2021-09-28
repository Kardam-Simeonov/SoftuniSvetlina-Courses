using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsGrade
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                string[] input = Console.ReadLine().Split();
                Student userStudent = new Student(input[0], input[1], double.Parse(input[2]));
                studentList.Add(userStudent);
            }

            foreach (var student in studentList.OrderByDescending(x => x.grade))
            {
                Console.WriteLine($"{student.firstName} {student.lastName}: {student.grade:f2}");
            }
        }
    }
}
