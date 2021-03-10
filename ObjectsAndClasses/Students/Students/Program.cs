using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "end")
                    break;

                Student student = new Student();

                student.firstName = input[0];
                student.lastName = input[1];
                student.age = int.Parse(input[2]);
                student.hometown = input[3];

                studentList.Add(student);
            }

            string hometown = Console.ReadLine();

            foreach (var student in studentList)
            {
                if (student.hometown == hometown)
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old");
            }
        }
    }

}
