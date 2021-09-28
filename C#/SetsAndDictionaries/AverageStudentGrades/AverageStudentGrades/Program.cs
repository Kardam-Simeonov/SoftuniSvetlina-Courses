using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (grades.ContainsKey(input[0]))
                    grades[input[0]].Add(decimal.Parse(input[1]));
                else
                    grades.Add(input[0], new List<decimal>() { decimal.Parse(input[1]) });
            }

            foreach (var student in grades)
            {
                Console.Write($"{student.Key} -> ");
                student.Value.ForEach(x => Console.Write($"{x:f2} "));
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
