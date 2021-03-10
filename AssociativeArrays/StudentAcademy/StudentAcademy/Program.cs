using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentList = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (studentList.ContainsKey(studentName))
                    studentList[studentName].Add(studentGrade);
                else
                    studentList.Add(studentName, new List<double> { studentGrade });
            }

            foreach (var student in studentList.OrderByDescending(key => key.Value.Average()))
            {
                if (student.Value.Average() >= 4.50)
                    Console.WriteLine($"{student.Key.TrimEnd()} -> {student.Value.Average():f2}");
            }
        }
    }
}
